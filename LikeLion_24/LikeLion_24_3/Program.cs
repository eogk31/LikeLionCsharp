using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_24_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. SORT 알고리즘(오름차순)
            Console.WriteLine("1. SORT 알고리즘");

            int[] data = { 5, 2, 8, 1, 9};
            Array.Sort(data);

            foreach(int i in data)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("================================");

            // 2. SEARCH 알고리즘 (선형 검색)
            Console.WriteLine("2. SEARCH 알고리즘 (선형 검색)");

            // 배열 선언
            int[] data2 = { 5, 2, 8, 1, 9 };

            // 찾고자 하는 수 입력
            int search = 8;

            // 검색 결과 저장. 최초 -1로 찾지 못한 경우를 대비한다.
            int index = -1;

            // for문으로 배열 길이만큼 반복.
            for(int i = 0; i < data2.Length; i++)
            {
                // if 조건: 배열 내 숫자가 찾고자 하는 수와 같다면 index에 i를 대입. 
                // 찾았다면 index에 i값을 대입 후 break로 종료.
                if (data2[i] == search)
                {
                    index = i;
                    break;
                }
            }

            // 결과 출력 (index가 0 이상이면 찾은 위치 출력, 아니라면 "Not found" 출력)
            // 현재 찾은 위치는 2번째 위치이므로 2가 출력된다.
            Console.WriteLine(index >= 0 ? $"Found at index {index}" : "Not found");

            Console.WriteLine("================================");

            // 3. GROUP 알고리즘
            Console.WriteLine("3. GROUP 알고리즘");

            // 배열 선언
            string[] data3 = { "apple", "banana", "blueberry", "cherry", "apricot" };

            // 그룹 알고리즘 선언
            // GroupBy(): 특정 기준에 따라 데이터를 그룹화. 여기서는 첫 글자를 조건으로 한다.
            // f => f[0]: 람다 표현식(=>) 각 문자의 첫 글자를 기준으로 그룹화.
            var groups = data3.GroupBy(f => f[0]);

            // 반복문 foreach로 배열을 반복
            foreach(var group in groups)
            {
                // 그룹 별 Key를 출력(각 그룹을 구분하는 첫 글자)
                Console.WriteLine($"Key: {group.Key}");
                // 해당 그룹에 속하는 원소를 출력
                foreach(var item in group)
                {
                    Console.WriteLine($" {item}");
                }
            }

            Console.WriteLine("================================");
        }
    }
}
