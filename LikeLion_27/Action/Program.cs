using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action2025
{

    class Program
    {
        static void SayHello()
        {
            Console.WriteLine("안녕하세요.");
        }

        static void Show()
        {
            Console.WriteLine("중요한 알림이 있습니다.");
        }

        static void HelloWorld(string message)
        {
            Console.WriteLine($"신규 메시지 : {message} ");
        }

        static void Main(string[] args)
        {
            Action sayHello = SayHello;

            sayHello += Show;

            sayHello?.Invoke();

            Action<string> h = null;

            h += HelloWorld;

            h?.Invoke("멋사");

            Action oti = null;
            oti += () => Console.WriteLine("인자가 없는 액션");
            oti?.Invoke();

            Action<int> Square = number => Console.WriteLine(number * number);

            Square(5);
        }
    }
}
