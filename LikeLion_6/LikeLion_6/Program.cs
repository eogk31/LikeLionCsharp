using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 숫자 데이터 형식
            // 숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            int integerNum = 10; // 정수 데이터
            float floatNum = 3.14f; // 단정밀도 실수
            double doubleNum = 3.14159; // 배정밀도 실수

            Console.WriteLine("===================================");
            Console.WriteLine("1. 숫자 데이터 형식");
            Console.WriteLine(integerNum); // 출력: 10
            Console.WriteLine(floatNum); // 출력: 3.14
            Console.WriteLine(doubleNum); // 출력: 3.14159
            Console.WriteLine("===================================");

            //2. 정수 데이터 형식
            // 정수 데이터 형식: 소수점이 없는 숫자를 표현
            int intValue = -100; // 4바이트 크기의 정수
            long longValue = 1234567890L; // 8바이트 크기의 정수

            Console.WriteLine("2. 정수 데이터 형식");
            Console.WriteLine(intValue); // 출력: -100
            Console.WriteLine(longValue); // 출력: 1234567890
            Console.WriteLine("===================================");

            //3. 부호 있는 정수 데이터 형식
            // 부호 있는 정수: 음수와 양수를 모두 표현 가능
            sbyte signedByte = -50; // 1바이트 크기
            short signedShort = -32000; // 2바이트 크기
            int signedInt = -2000000000; // 4바이트 크기

            Console.WriteLine("3. 부호 있는 정수 데이터 형식");
            Console.WriteLine(signedByte); // 출력: -50
            Console.WriteLine(signedShort); // 출력: -32000
            Console.WriteLine(signedInt); // 출력: -2000000000
            Console.WriteLine("===================================");

            //4. 부호 없는 정수 데이터 형식
            //부호 없는 정수: 0 이상의 정수만 표현 가능
            byte unsignedByte = 255; // 1바이트 크기
            ushort unsignedShort = 65000; // 2바이트 크기
            uint unsignedInt = 4000000000; // 4바이트 크기

            Console.WriteLine("4. 부호 없는 정수 데이터 형식");
            Console.WriteLine(unsignedByte); // 출력: 255
            Console.WriteLine(unsignedShort); // 출력: 65000
            Console.WriteLine(unsignedInt); // 출력: 4000000000
            Console.WriteLine("===================================");

            //5. 실수 데이터 형식
            // 실수 데이터 형식: 소수점을 포함한 숫자를 표현
            float singlePrecision = 3.14f; // 단정밀도 실수 (4바이트)
            double doublePrecision = 3.1415926535; // 배정밀도 실수 (8바이트)
            decimal highPrecision = 3.1415926535897932384626433833m; // 고정밀도(16바이트)

            Console.WriteLine("5. 실수 데이터 형식");
            Console.WriteLine(singlePrecision); // 출력: 3.14
            Console.WriteLine(doublePrecision); // 출력: 3.1415926535
            Console.WriteLine(highPrecision); // 출력: 3.1415926535897932384626433833
            Console.WriteLine("===================================");

            //6. 숫자 형식의 리터럴 값에 접미사 붙이기
            //접미사 사용: 숫자의 데이터 형식을 명시
            int i = 100; // 기본 정수형 (int)
            long l = 100L; // 정수형 (long)
            float f = 3.14f; // 실수형 (float)
            double d = 3.14d; // 기본 실수형 (double)
            decimal de = 3.14m; // 고정밀도 실수형 (decimal)

            Console.WriteLine("6. 숫자 형식의 리터럴 값에 접미사 붙이기");
            Console.WriteLine(i); //출력: 100
            Console.WriteLine(l); //출력: 100
            Console.WriteLine(f); //출력: 3.14
            Console.WriteLine(d); //출력: 3.14
            Console.WriteLine(de); //출력: 3.14
            Console.WriteLine("===================================");
        }
    }
}
