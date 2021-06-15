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
			int n, p;

			Console.WriteLine("Введите колличество заданий");
			n = Convert.ToInt32(Console.ReadLine());
			int[] nums = new int[n];
			Console.WriteLine("Введите длительность заданий");
			for (int i = 0; i < n; i++)
			{
				nums[i] = Convert.ToInt32(Console.ReadLine());
			}
			Console.WriteLine("Введите время начала I задания");
			p = Convert.ToInt32(Console.ReadLine());
			int[] ostat = { p };

			int q = 1;
			int j = 0;
			bool f;
			for (int i = 0; i < p; i++)                         
			{
				f = false;
				if (nums[i] <= p)                              
				{
					for (j = 0; j < q; j++)                    
					{

						if ((nums[i] <= ostat[j]))              
						{
							ostat[j] -= nums[i];
							Console.WriteLine(i + 1 + " готово " + (j + 1));
							f = true; j = q + 1;
						}
					}
					if (f == false)
					{                                           
						Insert(ref ostat, p, q);
						ostat[q] -= nums[i];
						Console.WriteLine(i + 1 + " готово " + (q + 1));
						q++;
						f = true;
					}
				}
			}
			Console.WriteLine("количество выполнений = " + q);
			Console.ReadLine();
		}
		static void Insert(ref int[] array, int value, int index) 
		{
			int[] newArray = new int[array.Length + 1];

			newArray[index] = value;

			for (int i = 0; i < index; i++)
				newArray[i] = array[i];
			for (int i = index; i < array.Length; i++)
				newArray[i + 1] = array[i];
			array = newArray;
		}
    }
}
