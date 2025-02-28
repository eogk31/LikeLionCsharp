using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_20_3
{
    //class Person
    //{
    //    private string name; //내부 변수

    //    //값 설정하기(setter)
    //    //내부 변수를 입력 값으로 바꿔주는 역할
    //    public void SetName(string newname)
    //    {
    //        name = newname;
    //    }

    //    //값 가져오기(getter)
    //    public string GetName()
    //    {
    //        return name;
    //    }

    //}

    //C# 프로퍼티 방식(property)
    //class Person
    //{
    //    private string name;

    //    public string Name
    //    {
    //        get { return name; } //Getter
    //        set { name = value; } //Setter
    //    }
    //}

    //프로퍼티를 자동으로 구현하는 방식
    //class Person
    //{
    //    private int count = 100;
    //    public string Name { get; set; } //자동 구현 프로퍼티
    //    public int Count
    //    {
    //        get { return count; } //get만을 사용해서 지정한 초기값 읽기만 가능.
    //    }

    //    public float Balance //외부에서 변경 불가능하게 set을 private로
    //    {
    //        get;
    //        private set;
    //    }

    //    public void AddBall()
    //    {
    //        Balance += 100;
    //    }
    //}

    class Marine
    {
        public string Name { get; private set; } = "마린";
        public int Mineral { get; set; } = 100;
    }


        class Program
        {
            static void Main(string[] args)
            {
                Marine m = new Marine();
                Console.WriteLine($"이름: {m.Name}, 미네랄: {m.Mineral}");
            }
        }
}
