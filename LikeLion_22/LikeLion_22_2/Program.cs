using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_22_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int age = -5;
                if (age < 0)
                    throw new ArgumentException("Age cannot be negative");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
