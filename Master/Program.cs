using System;

namespace Master
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Begin2◦. Дана сторона квадрата a. Найти его площадь S = a2. */
            Console.WriteLine("Введите сторону квадрата a");
            double a = Convert.ToDouble(Console.ReadLine());
            double S = a * a;
            Console.WriteLine("Площадь квадрата равна " + S);
            Console.ReadLine();
        }
    }
}