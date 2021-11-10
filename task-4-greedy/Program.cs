using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4_greedy
{
    class Program
    {
		static void Main(string[] args)
		{
			int n, t;

			Console.WriteLine("Введите количество заданий");
			n = Convert.ToInt32(Console.ReadLine());
			int[] nums = new int[n];
			int[] ostat = new int[n];
			for (int i = 0; i < nums.Length; i++)
			{
				int z = i + 1;
				Console.WriteLine("Введите длительность задания" + z);
				nums[i] = Convert.ToInt32(Console.ReadLine());
			}
			int all = nums.Sum();
			for (int i = 0; i < nums.Length; i++)
			{
				int z = i + 1;
				Console.WriteLine("Введите время начала" + z + "задания");
				t = Convert.ToInt32(Console.ReadLine());
				ostat.Append(t);
			}
			int start_time = ostat.Min();
			int task = Array.IndexOf(nums, start_time);
			ostat[task] = int.MaxValue;
			for(;  n>0; n-- )
            {
				int update_time = ostat.Min();
				int task_new = nums[Array.IndexOf(ostat,update_time)] ;
				ostat[update_time] = int.MaxValue;
                if (update_time > start_time + nums[task])
                {
					int completion = start_time + nums[task];
					Console.WriteLine("Задание" + task + "было сделано в " + completion+ "часов");
                }
                else
                {
					task = update_time - start_time;
					int completion = update_time + nums[task_new];
					Console.WriteLine("Задание" + task_new + "было сделано в " + completion + "часов");

				}
                
            }
		}
    }
}
