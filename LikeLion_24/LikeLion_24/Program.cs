using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_24
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 정렬과 검색
            Console.WriteLine("1. 데이터 정렬과 검색");

            string[] names = { "Charlie", "Alice", "Bob" };
            var sortedNames = names.OrderBy(n => n);
            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }
            var firstName = names.First(n => n.StartsWith("A"));
            Console.WriteLine($"First name starting with A: {firstName}");

            Console.WriteLine("====================================================");

            // 2. 메서드 구문과 쿼리 구문
            Console.WriteLine("2. 메서드 구문과 쿼리 구문");

            // 메소드, 쿼리 구문
            int[] nums = { 5, 3, 8, 1 };

            //메소드 구문
            var sortedMeshod = nums.OrderBy(n => n);

            //쿼리 구문
            var sortedQuery = from n in nums
                              orderby n
                              select n;

            Console.WriteLine("Meshod syntax: ");
            foreach(var n in sortedMeshod)
            {
                Console.Write(n);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("Query syntax: ");
            foreach(var i in sortedQuery)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("====================================================");

            // 3. Select( ) 확장 메서드를 사용하여 새로운 형태로 가공하기
            Console.WriteLine("3. Select( ) 확장 메서드를 사용하여 새로운 형태로 가공하기");

            string[] words = { "apple", "banana", "cherry" };

            var lengths = words.Select(w => w.Length);

            foreach(var w  in lengths)
            {
                Console.Write(w);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("====================================================");
        }
    }
}
