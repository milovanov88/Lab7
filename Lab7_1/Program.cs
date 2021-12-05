using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задайте стороны первого треугольника, a1, b1 и c1");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Задайте стороны второго треугольника, a2, b2 и c2");
            int a2 = Convert.ToInt32(Console.ReadLine());
            int b2 = Convert.ToInt32(Console.ReadLine());
            int c2 = Convert.ToInt32(Console.ReadLine());
            double S1, S2;
            GetS(a1, b1, c1, out S1);
            GetS(a2, b2, c2, out S2);
            if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника блольше");
            else
                Console.WriteLine("Площадь второго треугольника блольше");
            Console.ReadKey();
        }
        static void GetS(int a, int b, int c, out double S)
        {
            double p = (a + b + c) / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}