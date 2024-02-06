using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSummator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            double a, b, sum;
            bool ok;

            do
            {
                Console.Write("Введіть перше число: ");
                ok = double.TryParse(Console.ReadLine(), out a);
                if (!ok)
                    Console.WriteLine("Некоректне значення! Будь ласка повторіть введення ще раз!");
            } while (!ok);
            do
            {
                Console.Write("Введіть друге число: ");
                ok = double.TryParse(Console.ReadLine(), out b);
                if (!ok)
                    Console.WriteLine("Некоректне значення! Будь ласка повторіть введення ще раз!");
            } while (!ok);
            sum = a + b;
            Console.WriteLine($"Сума: {sum}");
        }
    }
}
