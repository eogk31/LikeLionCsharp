using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//인벤토리 만들기 예제
//배열과 함수로 인벤토리를 구현해보자.
//과제에서의 변경점: 구조체와 함수를 사용해서 바꿀 부분을 바꾸자.
namespace Inventory
{
    class Program
    {
        //최대 아이템 개수(배열 크기)
        const int MAX_ITEMS = 10;

        //아이템을 관리하는 구조체 선언
        struct Item
        {
            public string name;
            public int count;

            public void Print()
            {
                //name이 부여되지 않았다면 배열에 나타나지 않도록
                //IsNullOrEmpty로 칸이 비어있을 때를 !로 반전시켜 출력.
                if (!string.IsNullOrEmpty(name))
                {
                    Console.WriteLine($"{name} (x{count})");
                }
            }
        }

        //구조체의 배열을 사용하고자 배열을 선언.
        static Item[] inventory = new Item[MAX_ITEMS];

        //아이템 추가 함수
        static void AddItem(string name, int count)
        {
            //이미 있는 아이템이라면 개수만 증가
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inventory[i].name == name)
                {
                    inventory[i].count += count;
                    return;
                }
            }

            //빈 슬롯에 새로운 아이템을 추가하는 부분, 이름과 개수 동시 증가
            for (int i = 0; i < MAX_ITEMS; i++)
            {
                if (inventory[i].name == null)
                {
                    inventory[i].name = name;
                    inventory[i].count += count;
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
                if (inventory[i].name == name) //버리려는 아이템과 이름을 같고
                {
                    if (inventory[i].count >= count) //개수가 충분하면 차감이 가능
                    {
                        inventory[i].count -= count;
                        if (inventory[i].count == 0)
                        {
                        inventory[i].name = null;
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

        //아이템 인벤토리를 보여주는 함수.
        static void ShowInventory()
        {
            Console.WriteLine("현재 인벤토리: ");
            foreach (var i in inventory)
            {
                i.Print();
            }
        }

        //아이템 인벤토리의 상황을 지속해서 출력시켜주는 함수
        //out 키워드로 추가 및 삭제 명령어, 아이템 이름, 아이템 수 순서대로 내보낸다.
        static void inputInventory(out string item, out string itemName, out int itemCount)
        {
            Console.Write("아이템을 추가하시겠습니까? / 버리시겠습니까?: ");
            string input = Console.ReadLine();
            string[] parts = input.Split(' ');

            item = parts[0];
            itemName = parts[1];
            itemCount = int.Parse(parts[2]);
        }

        static void Main(string[] args)
        {
            string item;
            string name;
            int count;
            
            inventory[0] = new Item { name = "포션", count = 10 };
            inventory[1] = new Item { name = "칼", count = 1 };

            //while 반복문으로 계속해서 인벤토리의 상황을 보여주며 추가/삭제를 반복
            //중첩 조건문 if-else if는 추가와 삭제를 이룬다.
            while (true)
            {
                ShowInventory();
                inputInventory(out item, out name, out count);
                if (item == "add")
                {
                    AddItem(name, count);
                }
                else if (item == "remove")
                {
                    RemoveItem(name, count);
                }
                else
                    Console.WriteLine("잘못된 입력입니다.");
            }
        }
     }
}
