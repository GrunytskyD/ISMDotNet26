using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A");
            double numbera = double.Parse(Console.ReadLine());
            Console.WriteLine("B");
            double numberb = double.Parse(Console.ReadLine());
            double summaAB = numbera * numberb;
            Console.WriteLine($"summa{summaAB}");

            
        }
    }
}
