using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202502026_Homework
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            //1번
            int[] iArr = new int[5] { 10, 20, 30, 40, 50 };
            Console.WriteLine("Q1. 크기가 5인 정수 배열을 만들고, {10, 20, 30, 40, 50} 값을 저장한 후 출력하세요.");
            for (int i = 0; i < iArr.Length; i++)
            {
                Console.Write($"{iArr[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine("===================================================================================");

            //2번
            int sum = 0;
            int[] sumArr = new int[5];

            Console.WriteLine("Q2. 사용자가 5개의 정수를 입력하면 배열에 저장하고, 모든 수의 합을 출력하세요.");

            for (int i = 0; i < sumArr.Length; i++)
            {
                Console.Write($"숫자 {i + 1} 입력: ");
                sumArr[i] = int.Parse(Console.ReadLine());
                sum += sumArr[i]; 
            }

            Console.WriteLine($"합계: {sum}");
            Console.WriteLine("===================================================================================");

            //3번
            int[] maxArr = new int[5] { 3, 8, 15, 6, 2 };
            int max = 0;
            Console.WriteLine("Q3. 정수 배열 {3, 8, 15, 6, 2}에서 가장 큰 값을 찾아 출력하세요.");
            for (int i = 0; i < maxArr.Length; i++)
            {
                if (maxArr[i] > max)
                    max = maxArr[i];
            }
            Console.WriteLine($"최댓값: {max}");
            Console.WriteLine("===================================================================================");

            //4번
            Console.WriteLine("Q4. for문을 사용하여 1부터 10까지 출력하세요.");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
            Console.WriteLine("===================================================================================");

            //5번
            Console.WriteLine("Q5. while문을 사용하여 1부터 10까지 중 짝수만 출력하세요.");
            for (int i = 1; i <= 10; i++)
            {
                while (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("===================================================================================");

            //6번
            int[] eachArr = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Q6. foreach문을 사용하여 배열 {1, 2, 3, 4, 5}의 요소를 출력하세요.");
            foreach (int i in eachArr)
            {
                Console.Write($" {i} ");
            }
            Console.WriteLine();
            Console.WriteLine("===================================================================================");

            //7번
            int x = 0, y = 0;
            Console.WriteLine("Q7. 두 개의 정수를 입력받아 합을 반환하는 함수를 작성하세요.");

            Console.Write("x 입력: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("y 입력: ");
            y = int.Parse(Console.ReadLine());

            int result = Add(x, y);

            Console.WriteLine($"합계: {x} + {y} = {result}");
            Console.WriteLine("===================================================================================");

            //8번
            Console.WriteLine("Q8. 문자열을 입력받아 길이를 반환하는 함수를 작성하세요.");
            Console.Write("문자열 입력: ");
            string index = Console.ReadLine();
            int length = 0;

            for (int i = 0; i < index.Length; i++)
            {
                length++;
            }
            Console.WriteLine($"문자열의 길이: {length}");
            Console.WriteLine("===================================================================================");

            //9번
            int n = 0;
            Console.WriteLine("Q9. 세 개의 정수를 입력받아 가장 큰 값을 반환하는 함수를 작성하세요.");
            for (int i=0; i<3; i++)
            {
                Console.Write($"정수 입력 {i+1}: ");
                int m = int.Parse(Console.ReadLine());
                if (n < m)
                    n = m;
            }
            Console.WriteLine($"최댓값은 {n}입니다.");
        }
    }
}
