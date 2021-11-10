using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_job_assigner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество заданий для выполнения");
            int[] tasks = new int[Convert.ToInt32(Console.ReadLine())];
            int[] best = new int[tasks.Length];
            int[] skip = new int[tasks.Length];
            int[] comparison = new int[tasks.Length];
            for (int filler = 0; filler < tasks.Length; filler++)
            {
                skip[filler] = int.MinValue;
            }

            
            for (int i = 0; i < tasks.Length; i++)
            {

                for (int f = 0; f < tasks.Length; f++)
                {
                    if (skip.Contains(f) == true)
                    {
                        while(skip.Contains(f) == true)
                        {
                            f++;
                        }
                    }
                    Console.WriteLine("Введите цену задания " + (i + 1) + " для работника " + (f + 1));
                    int price = Convert.ToInt32(Console.ReadLine());
                    comparison[f] = price;
                    
                }
                best[i] = comparison.Min();
                skip[i] =  Array.IndexOf(comparison, best.GetValue(i));
                int nummer = skip.ElementAt(i) + 1;
                Console.WriteLine(best[i] + " - лучшая цена (от работника " + nummer + ')'); ;
                for (int filler = 0; filler < tasks.Length; filler++)
                {
                    comparison[filler] = int.MaxValue;
                }
            }
            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey();
        }
    }
}
