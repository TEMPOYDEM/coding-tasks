using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_multipliers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a;
                int b;
                int c;
                Console.WriteLine("Введите 3 значения для расчёта");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a < 0)
                    {
                        Console.WriteLine("Отрицательные значения не допускаются");
                        Console.ReadKey();
                    }
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b < 0)
                    {
                        Console.WriteLine("Отрицательные значения не допускаются");
                        Console.ReadKey();
                    }
                    c = Convert.ToInt32(Console.ReadLine());
                    if (c < 0)
                    {
                        Console.WriteLine("Отрицательные значения не допускаются");
                        Console.ReadKey();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Попробуйте ввести ещё раз");
                    continue;
                }

                Console.WriteLine("НОК=" + nok(a, b, c));
                Console.WriteLine("НОД=" + nod(a, b, c));
                Console.ReadKey();

            }
        }
        static double nok(int a, int b, int c)
        {
            double first = a * b * c;
            for (int i = 1; i <= first; i++)
            {
                if ((i % a == 0) && (i % b == 0) && (i % c == 0))
                {
                    return i;
                }
            }
            return first;
        }
        static double nod(int a, int b, int c)
        {
            int second = Math.Min(a, Math.Min(b, c));
            for (; second > 1; second--)
            {
                if (a % second == 0 && b % second == 0 && c % second == 0)
                    break;
            }
            return second;
        }

    }

}

