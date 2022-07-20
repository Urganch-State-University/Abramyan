using System;

namespace Master
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Begin1◦. Дана сторона квадрата a. Найти его периметр P = 4·a. */
            Console.WriteLine("Введите сторону квадрата a:");
            double a = Convert.ToDouble(Console.ReadLine());
            double P = 4 * a;
            Console.WriteLine("Периметр квадрата равен {0}", P);
            Console.ReadLine();
        }
    }
}