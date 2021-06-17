using System;
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
            int[,] work = new int[tasks.Length,tasks.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                for (int f = 0; f < tasks.Length; f++)
                {
                    Console.WriteLine("Введите цену задания " + (f + 1) + " для работника " + (i + 1));
                    int price = Convert.ToInt32(Console.ReadLine());
                    work[i, f] = price;
                }
            }
            int[] comparison = new int[tasks.Length];
            for (int i = 0; i<tasks.Length;i++)
            {
                var max = Enumerable.Range(0, work.GetLength(1)).Max(best => work[1, best]);
                Console.WriteLine(max);
            }

            Console.ReadLine();
        }
    }
}
