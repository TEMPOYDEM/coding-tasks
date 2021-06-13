using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5_golden_section
{
    class Program
    {
        static void Main(string[] args)
        {
            double gold = (1 + Math.Sqrt(5)) / 2;
            double A = 2;
            double B = -1;
            double a = 1;
            double b = 5;
            double accuracy = 0.0000001;
            double c;
            double x;
            while (b - a > accuracy)
            {
                Console.WriteLine("--------------------------------------------------");
                c = a + (b - a) / gold;
                x = a + b - c;
                if (c > x)
                {
                    if (A * Math.Log(c) + B*c > A * Math.Log(c) + B * x)
                    {
                        b = c;
                    }
                    else
                    {
                        a = x;
                    }
                }
                else
                {
                    if (c < A * Math.Log(c) + B * c)
                    {
                        a = c;
                    }
                    else
                    {
                        b = x;
                    }

                }
                Console.WriteLine("Начало отрезка: " + a);
                Console.WriteLine("Конец отрезка: " + b);
                Console.WriteLine("Точка экстремума: " + x);

            }
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("||||||||||||||||||||||||||||||||||");
            Console.WriteLine("Итоговый результат");
            Console.ReadKey();
        }
    }
}

