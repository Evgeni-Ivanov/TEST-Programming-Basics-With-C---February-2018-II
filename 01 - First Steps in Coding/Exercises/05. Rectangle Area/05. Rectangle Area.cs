using System;

namespace _05.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var rectangleArea = a * b;

            Console.WriteLine(rectangleArea);
        }
    }
}
