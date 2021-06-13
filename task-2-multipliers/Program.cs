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
            var f = 1;
            while(f != 0)
            {
                int[] i = new int[3];
                Console.WriteLine("Введите через ENTER 3 положительных целых числа");
                try
                {
                    for (int j = 0; j < 3; j++)
                    {
                        int k = int.Parse(Console.ReadLine());                        
                        if (k <= 0)
                        {
                            Console.WriteLine("Вы ввели не положительное число");
                        }
                        else
                        {
                            i[j] = k;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Ошибка ввода, попробуйте снова");
                }
                int a_min = 0;
                int a = i.ElementAt(0);
                int b = i.ElementAt(1);
                int c = i.ElementAt(2);
                if (a > b)
                {
                    a_min = a % b;
                }
                else if (b > a)
                {
                    a_min = b % a;
                }
                else if(b == a)
                {
                    a_min = b;
                }
                if (a_min == 0)
                {
                    a_min = a;
                }
                Console.WriteLine(a_min);
                ////////////////////////////////////////////////////////////////
                int b_min = 0;
                a = i.ElementAt(0);
                b = i.ElementAt(1);
                c = i.ElementAt(2);
                if (a > c)
                {
                    b_min = a % c;
                }
                else if (c > a)
                {
                    b_min = c % a;
                }
                else if (c == a)
                {
                    b_min = c;
                }
                if (b_min == 0)
                {
                    b_min = a;
                }
                Console.WriteLine(b_min);
                ////////////////////////////////////////////////
                int c_min =0;
                a = i.ElementAt(0);
                b = i.ElementAt(1);
                c = i.ElementAt(2);
                if (b > c)
                {
                    c_min = b % c;
                }
                else if (c > b)
                {
                    c_min = c % b;
                }
                else if (c == b)
                {
                    c_min = c;
                }
                if (c_min == 0)
                {
                    c_min = a;
                }
                /////////////////////////////////////////////////////////////////////////////////////
                Console.WriteLine(b_min);

                if (a_min == b_min && a_min == c_min)
                {
                    Console.WriteLine(b_min + "НОд");
                }
                else if (a_min == b_min && a_min != c_min)
                {
                    if (a_min > c_min)
                    {
                        a_min = a_min % c_min;
                    }
                    else if (a_min < c_min)
                    {
                        a_min = c_min % a_min;
                    }
                    Console.WriteLine(a_min + "НОд");
                }
                else if (a_min == c_min && a_min != b_min)
                {
                    if (a_min > b_min)
                    {
                        a_min = a_min % b_min;
                    }
                    else if (a_min < b_min)
                    {
                        a_min = b_min % a_min;
                    }
                    Console.WriteLine(a_min + "НОд");
                }
                Console.WriteLine("Для выхода из программы нажмите 0. Чтобы начать сначала, введите любое другое число");
                f = Convert.ToInt32(Console.ReadKey());
                
            }

        }
    }
}
