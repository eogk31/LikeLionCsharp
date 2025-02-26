using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////3명의 학생의 성적을 입력받아 출력
            //int[] ikor = new int[3];
            //int[] ieng = new int[3];
            //int[] imath = new int[3];

            //int[] sum = new int[3];
            //double[] avg = new double[3];

            //for(int i=0; i<3; i++)
            //{
            //    Console.WriteLine("학생들의 성적을 입력: ");
            //    Console.Write("국어: ");
            //    ikor[i] = int.Parse(Console.ReadLine());

            //    Console.Write("영어: ");
            //    ieng[i] = int.Parse(Console.ReadLine());

            //    Console.Write("수학: ");
            //    imath[i] = int.Parse(Console.ReadLine());

            //    sum[i] += ikor[i] + ieng[i] + imath[i];
            //    avg[i] = sum[i] / 3;
            //}

            ////출력
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"{i+1}번 학생");
            //    Console.WriteLine($"국어: {ikor[i]}, 영어: {ieng[i]}, 수학:{imath[i]}");
            //    Console.WriteLine($"점수 합계: {sum[i]}");
            //    Console.WriteLine($"점수 평균: {avg[i]:F2}");
            //}
            //Console.WriteLine($"각 학생들의 점수 합계: {sum[0]}, {sum[1]}, {sum[2]}");
            //Console.WriteLine($"각 학생들의 점수 평균: {avg[0]}, {avg[1]}, {avg[2]}");

            ////1차원 배열
            //int[] scores = new int[3];

            //scores[0] = 100;
            //scores[1] = 90;
            //scores[2] = 87;

            //for(int i=0; i<scores.Length; i++)
            //{
            //    Console.WriteLine($"점수: {i + 1}:{scores[i]}");
            //}

            ////2차원 배열
            //int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            ////2차원 배열 반복 순회
            //for(int i=0; i<2; i++) //0,1
            //{
            //    for(int j=0; j<3; j++) //0,1,2
            //    {
            //        Console.Write($"{matrix[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}

            ////가변 배열
            //int[][] jagged = new int[3][];
            //jagged[0] = new int[] { 1, 2 };
            //jagged[1] = new int[] { 3, 4, 5 };
            //jagged[2] = new int[] { 6 };

            ////가변 배열 반복 순회
            //for (int i = 0; i < jagged.Length; i++)
            //{
            //    for (int j = 0; j < jagged[i].Length; j++)
            //    {
            //        Console.Write($"{jagged[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}

            ////var 키워드로 배열 선언하기
            //Console.WriteLine("\n=== var 키워드 사용 ===");
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"배열 타입: {numbers.GetType()}");
        }
    }
}
