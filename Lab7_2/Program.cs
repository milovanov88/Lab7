using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте ребро куба");
            int a = Convert.ToInt32(Console.ReadLine());
            double P, V;
            GetP(a, out P);
            GetV(a, out V);
            Console.WriteLine("Площадь куба равна {0}", P);
            Console.WriteLine("Объём куба равен {0}", V);
            Console.ReadKey();
        }
        static void GetP(int a, out double P)
        {
            P = a * a;
        }
        static void GetV(int a, out double V)
        {

            V = a * a * a;

        }
    }
}
