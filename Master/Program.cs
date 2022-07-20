using System;

namespace Master
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Begin3◦. Даны стороны прямоугольника a и b. Найти его площадь S = a·b и
 периметр P = 2·(a + b). */
            Console.WriteLine("Введите сторону прямоугольника a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону прямоугольника b:");
            double b = Convert.ToDouble(Console.ReadLine());
            double S = a * b;
            double P = 2 * (a + b);
            Console.WriteLine("Площадь прямоугольника S = {0} и периметр P = {1}", S, P);
            Console.ReadLine();
        }
    }
}