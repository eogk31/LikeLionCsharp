using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_23_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stack 제네릭 클래스 사용하기
            Console.WriteLine("Stack 제네릭 클래스 사용하기");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.WriteLine("======================================");

            //  List〈T〉 제네릭 클래스 사용하기
            Console.WriteLine("List〈T〉 제네릭 클래스 사용하기");

            List<string> names = new List<string> { "vram", "valen"};
            names.Add("gavv");

            foreach (var n in names)
            {
                Console.WriteLine($"{n}");
            }

            Console.WriteLine("======================================");

            // Enumerable 클래스로 컬렉션 만들기 출력 부분
            Console.WriteLine("Enumerable 클래스로 컬렉션 만들기");

            var collection = new Simple();
            foreach(var n in collection)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("======================================");
        }
    }

    // Enumerable 클래스로 컬렉션 만들기
    class Simple : IEnumerable<int>
    {
        private int[] data = { 1, 2, 3, 4, 5 };
        public IEnumerator<int> GetEnumerator()
        {
            foreach(int i in data)
            {
                yield return i;
            }
        }
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
