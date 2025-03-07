using System;

namespace LikeLion_27
{
    class Program
    {
        // 1. 델리게이트 사용해보기
        delegate void MessageHandler(string message);

        // 델리게이트에 연결할 메소드
        static void DisplayMessage(string message)
        {
            Console.WriteLine($"메시지 : {message}");
        }

        static void DisplayUpperMessage(string message)
        {
            Console.WriteLine($"대문자 메시지 : {message.ToUpper()}");
        }

        static void Main(string[] args)
        {
            // 1. 출력 부분
            Console.WriteLine("1. 델리게이트 사용해보기");

            // 델리게이트 변수 선언 및 메소드 연결
            MessageHandler m = DisplayMessage;

            // 델리게이트 호출
            Console.WriteLine("delegate 1");
            m("Hello, World!");

            // 여러 개의 메소드 연결
            m += DisplayUpperMessage;

            // 등록된 모든 메소드가 순서대로 호출됨
            Console.WriteLine("\n여러 메소드 호출:");
            m("Hello, Delegates!");

            Console.WriteLine("========================================");
        }
    }
}
