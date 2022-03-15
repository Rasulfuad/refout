using System;

namespace ConsoleApp1.ref_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num2 = 10;
            Baku(ref  num2);
                Console.WriteLine($"method {num2}");






        }


        static void Baku(ref int num1)
        {
            
            Console.WriteLine($"method {num1}");
        }






    }
}
