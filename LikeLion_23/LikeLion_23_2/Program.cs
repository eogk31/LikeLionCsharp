using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_23_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. ArrayList 클래스
            Console.WriteLine("1. ArrayList 클래스");

            // ArrayList 생성
            ArrayList array = new ArrayList();

            // 요소 추가
            array.Add(1);
            array.Add("Hello");
            array.Add(3.14);

            // 요소 접근
            Console.Write("ArrayList 요소 : ");

            foreach (var item in array)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();

            // 요소 제거
            array.Remove(1);

            Console.Write("ArrayList 요소 제거 후 : ");

            foreach (var item in array)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("======================================================");

            // 2. Hashtable 클래스
            Console.WriteLine("2. Hashtable 클래스");

            // Hashtable 생성
            Hashtable hash = new Hashtable();

            // 키-값 쌍 추가
            hash["Alice"] = 25;
            hash["Bob"] = 30;
            hash["포션"] = 20;

            // 접근
            Console.WriteLine("HashTable 요소 : ");
            Console.WriteLine();
            foreach (DictionaryEntry entry in hash)
            {
                Console.WriteLine(($"Key: {entry.Key}, Value: {entry.Value}"));
            }
            Console.WriteLine();

            // 특정 키의 값 가져오기
            Console.WriteLine($"\nAlice의 나이: {hash["Alice"]}");

            // 요소 제거
            hash.Remove("Bob");

            Console.WriteLine("\n요소 제거 후 Hash:");
            Console.WriteLine();
            foreach (DictionaryEntry entry in hash)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }

            Console.WriteLine("======================================================");

            // 3. 출력 부분
            Console.WriteLine("3. 제네릭(Cup of T)");

            Cup<string> CupOfString = new Cup<string> { content = "Coffee" };
            Cup<int> CupOfInt = new Cup<int> { content = 7 };

            Console.WriteLine($"CupOfString : {CupOfString.content}");
            Console.WriteLine($"CupOfInt : {CupOfInt.content}");
            Console.WriteLine("======================================================");

            // #. IEnumerator
            Console.WriteLine("#. IEnumerator");

            //배열 선언
            ArrayList arr = new ArrayList { "pudding", "jelly" };

            //열거자 가져오기
            IEnumerator enumerator = arr.GetEnumerator(); 

            //다음 요소가 있는 지 반복문으로 확인
            while( enumerator.MoveNext() )
            {
                Console.Write(enumerator.Current);
                Console.Write(" ");
            }
            Console.WriteLine();
            Console.WriteLine("======================================================");
        }
    }

    // 3. 제네릭(Cup of T)
    class Cup<T>
    {
        public T content { get; set; }
    }
}
