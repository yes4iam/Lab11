using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент k");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            double b = Convert.ToDouble(Console.ReadLine());
            LinearFunction kxb = new LinearFunction(k, b);
            Console.WriteLine(kxb.Root());
            Console.ReadKey();
        }
    }
}
