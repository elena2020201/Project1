using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace больш_меньш_конс
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Введите число");
            string sum = Console.ReadLine();
            int a = int.Parse(sum);
            int b = a - 1;
            int c = a + 1;
            Console.WriteLine("Последовательность " + b + "  " + a + "  " + c);
            Console.ReadLine();
        }
    }
}