using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_19
{
    //2. 구조체 만들기
    struct Rectangle
    {
        public int width;
        public int height;

        public int GetArea() => width * height;
    }

    //3. 구조체의 배열 만들기
    struct Point2
    {
        public int a;
        public int b;
    }

    //문제. 구조체를 이용해서 학생 3명의 성적(국어, 영어, 수학)을 받아 출력
    struct Score
    {
        public string name;
        public int korea;
        public int english;
        public int math;

        //학생 정보를 출력하는 함수
        public void Print()
        {
            Console.WriteLine($"{name, -10} {korea, -5} {english,-5} {math,-5}");
        }
    }

    class Program
    { 
        //1. 구조체 struct
        struct Point
        {
            //public = 어디서든 사용 가능한 접근 제한자.
            public int x;
            public int y;

            //생성자
            //public Point(int x, int y)
            //{
            //    this.x = x;
            //    this.y = y;
            //}

            public void Print()
            {
                Console.WriteLine("1. 구조체 struct");
                Console.WriteLine($"좌표: {x}, {y}");
                Console.WriteLine("========================================");
            }
        }


        static void Main(string[] args)
        {
            //1. 출력 부분
            Point p; //구조체 선언(초기화 필요)
            p.x = 10; p.y =20;
            p.Print();

            //생성자 출력 부분
            //Point point = new Point(10, 20);
            //point.Print();

            //2. 출력 부분
            var rect = new Rectangle { width = 5, height = 4 };
            Console.WriteLine("2. 구조체 만들기");
            Console.WriteLine($"Area: {rect.width} * {rect.height} = {rect.GetArea()}");
            Console.WriteLine("========================================");

            //3. 출력 부분
            Point2[] points = new Point2[2];

            points[0].a = 10;
            points[1].a = 20;

            points[0].b = 5;
            points[1].b = 9;

            Console.WriteLine("3. 구조체의 배열 만들기");
            foreach (var i in points)
            {
                Console.WriteLine($"Point: ({i.a}, {i.b})");
            }
            Console.WriteLine("========================================");

            //문제 출력 부분
            Console.WriteLine("구조체 문제 출력");
            Score[] scores = new Score[3];

            scores[0] = new Score { name = "홍길동", korea = 100, english = 80, math = 70 };
            scores[1] = new Score { name = "홍길란", korea = 90, english = 10, math = 20 };
            scores[2] = new Score { name = "홍길순", korea = 20, english = 55, math = 70 };

            foreach(var i in scores)
            {
                Console.WriteLine($"{i.name} {i.korea} {i.english} {i.math}");
            }
            Console.WriteLine("========================================");
        }
    }
}
