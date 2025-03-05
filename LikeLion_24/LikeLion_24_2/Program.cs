using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_24_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. SUM 알고리즘
            Console.WriteLine("1. SUM 알고리즘");

            int[] data = { 1, 2, 3, 4, 5 };
            int sum = 0;
            Console.Write("합계 : ");
            foreach (int i in data)
                sum += i;
            Console.WriteLine(sum);

            Console.WriteLine("=====================================");

            // 2. COUNT 알고리즘
            Console.WriteLine("2. COUNT 알고리즘");

            int[] data2 = { 2, 4, 6, 8, 10 };
            int count = data.Length;
            Console.WriteLine($"배열의 개수 : {count}");

            Console.WriteLine("=====================================");

            // 3. AVERAGE 알고리즘
            Console.WriteLine("3. AVERAGE 알고리즘");

            int[] data3 = { 80, 76, 65 };
            double average = data3.Average();
            Console.WriteLine($"배열의 평균 : {average:F2}");

            Console.WriteLine("=====================================");

            // 4. MAX 알고리즘
            Console.WriteLine("4. MAX 알고리즘");

            int[] data4 = { 10, 3, 5, 2, 8 };
            int max = data4.Max();
            Console.WriteLine($"배열의 최댓값 : {max}");

            Console.WriteLine("=====================================");

            // 5. MIN 알고리즘
            Console.WriteLine("5. MIN 알고리즘");

            int[] data5 = { 55, 76, 45 };
            int min = data5.Min();
            Console.WriteLine($"배열의 최솟값 : {min}");

            Console.WriteLine("=====================================");

            // 6. NEAR 알고리즘
            Console.WriteLine("6. NEAR 알고리즘");

            // 배열 선언
            int[] data6 = { 10, 12, 20, 25, 30 };

            // 목표로 하는 값 선언
            int target = 22;

            // 근사값이 들어갈 변수 near에는 최초로 배열의 첫 수를 대입
            int near = data6[0];

            // foreach 반복문으로 배열을 반복
            foreach( var i in data6)
            {
                //if 조건: 배열 내 수 - 목표값이 근사값 변수 - 목표값보다 작으면 near에 배열 내 수를 대입
                //Math.Abs로 절대값 계산.
                if (Math.Abs(i - target) < Math.Abs(near - target))
                    near = i;
            }

            Console.WriteLine($"{target}의 근사값 : {near}");

            Console.WriteLine("=====================================");

            // 7. RANK 알고리즘
            Console.WriteLine("7. RANK 알고리즘");

            // 배열 선언 (각 학생의 점수를 저장)
            int[] data7 = { 90, 70, 50, 70, 60 };

            // for문을 이용해 배열의 모든 요소(점수)를 반복하여 순위를 계산
            for (int i = 0; i < data7.Length; i++)
            {
                // 현재 점수의 순위를 1로 초기화 (기본적으로 1등으로 가정)
                int rank = 1;

                // 배열 내의 모든 요소와 비교하여 순위 결정
                for (int j = 0; j < data7.Length; j++)
                {
                    // 현재 비교 중인 값(data7[j])이 기준 값(data7[i])보다 클 경우, 기준 값의 순위(rank)를 증가
                    if (data7[j] > data7[i])
                        rank++;
                }

                // 각 점수와 해당 점수의 순위를 출력
                Console.WriteLine($"Score: {data7[i]}, Rank: {rank}");
            }


            Console.WriteLine("=====================================");
        }
    }
}
