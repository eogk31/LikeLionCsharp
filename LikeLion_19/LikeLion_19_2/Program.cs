using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_19_2
{
    class Program
    {
            //최대 아이템 개수(배열 크기)
            const int MAX_ITEMS = 10;

            //아이템 배열(이름 저장)
            static string[] itemNames = new string[MAX_ITEMS];
            static int[] itemCounts = new int[MAX_ITEMS];

            //아이템 추가 함수
            static void AddItem(string name, int count)
            {
                //이미 있는 아이템이라면 개수만 증가
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] == name)
                    {
                        itemCounts[i] += count;
                        return;
                    }
                }

                //빈 슬롯에 새로운 아이템을 추가하는 부분, 이름과 개수 동시 증가
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] == null)
                    {
                        itemNames[i] = name;
                        itemCounts[i] += count;
                        return;
                    }
                }

                Console.WriteLine("인벤토리가 가득 찼습니다.");
            }

            //아이템을 제거하는 함수 생성
            static void RemoveItem(string name, int count)
            {
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] == name) //버리려는 아이템과 이름을 같고
                    {
                        if (itemCounts[i] >= count) //개수가 충분하면 차감이 가능
                        {
                            itemCounts[i] -= count;
                            if (itemCounts[i] == 0)
                            {
                                itemNames[i] = null;
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("아이템 개수가 부족합니다.");
                            return;
                        }
                    }
                }

                Console.WriteLine("아이템을 찾을 수 없습니다.");
            }

            //인벤토리를 직접 출력해주는 함수 작성
            static void ShowInventory()
            {
                Console.WriteLine("현재 인벤토리: ");
                bool isEmpty = true;
                for (int i = 0; i < MAX_ITEMS; i++)
                {
                    if (itemNames[i] != null)
                    {
                        Console.WriteLine($"{itemNames[i]} (x{itemCounts[i]})");
                        isEmpty = false;
                    }
                }

                if (isEmpty)
                {
                    Console.WriteLine("인벤토리가 비어 있습니다.");
                }
            }

            static void Main(string[] args)
            {
                //인벤토리 출력 테스트
                AddItem("포션", 5);
                AddItem("칼", 1);
                AddItem("포션", 5); //포션 개수 추가

                ShowInventory();

                //아이템 사용 테스트
                Console.WriteLine("포션 2개 사용");
                RemoveItem("포션", 2);
                ShowInventory();

                //없는 아이템 제거 시도 테스트
                Console.WriteLine("방패 제거");
                RemoveItem("방패", 1);
                ShowInventory();

                //모든 포션 제거 테스트
                Console.WriteLine("포션 8개 사용(초과 사용 테스트)");
                RemoveItem("포션", 8);
                ShowInventory();

                //아이템 초과 제거 테스트
                Console.WriteLine("포션 초과 사용 테스트");
                RemoveItem("포션", 10);
                ShowInventory();
            }
        }
}
