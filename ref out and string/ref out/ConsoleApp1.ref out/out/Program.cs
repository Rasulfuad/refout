using System;

namespace outders
{
    internal class Program
{
    static void Main(string[] args)
    {
       int  num2;
        Baku(out num2);
        Console.WriteLine(num2);

    }



    static void Baku(out int num1)
    {
        num1 = 8;
        Console.WriteLine($"method {num1}");
    }
}
}
