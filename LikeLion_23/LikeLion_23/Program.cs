using System;
using System.Collections.Generic;
using System.Collections;
//System.Collections 비제네릭 버전
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_23
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 배열과 컬렉션
            int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("1.배열과 컬렉션");

            foreach (var number in numbers) 
            {
                Console.Write(number);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("=======================================");

            //2. 리스트 출력 구문
            Console.WriteLine("2. 리스트 출력 구문");

            List<string> names = new List<string> {  "Alice", "Bob", "Charlie"  };
            names.Add("Tom");
            names.Remove("Bob");

            foreach(var name in names)
            {
                Console.Write(name);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("=======================================");

            //2-1. 배열 관련 메소드
            Console.WriteLine("2-1. 배열 관련 메소드");

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.Insert(1, 100); //1의 자리를 100으로

            list[2] = 200; //2의 자리에 200 대입

            foreach (int i in list)
            {
                Console.Write(i);
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine($"Count: {list.Count}");

            Console.WriteLine("=======================================");

            //3. 스택(Stack)
            Console.WriteLine("3. 스택(Stack)");

            Stack<int> stack = new Stack<int>();
            //Stack stack = new Stack();은 비제네릭 버전으로 사용 가능.
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            while(stack.Count > 0)
            {
                Console.Write(stack.Pop());
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("=======================================");

            // 4. 큐(Queue)
            Console.WriteLine("4. 큐(Queue)");

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            while(queue.Count > 0)
            {
                Console.Write(queue.Dequeue());
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("=======================================");

            //#
            Queue queue1 = new Queue();

            queue1.Enqueue("q");
            queue1.Enqueue("w");
            queue1.Enqueue("e");
            queue1.Enqueue("r");
            queue1.Enqueue("점멸");
            queue1.Enqueue("평타");

            while (queue1.Count > 0)
            {
                Console.Write(queue1.Dequeue());
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("=======================================");
        }
    }
}
