using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_sorting
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {

                double[] numbers = new double[24];

                Console.WriteLine("Введите 24 числа через Enter");

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write("{0}-е число: ", i + 1);
                    numbers[i] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("Введите номер необходимой операции и нажмите Enter");
                Console.WriteLine("1. Ввести числа заново");
                Console.WriteLine("2. Полная сортировка пузырьком");
                Console.WriteLine("3. Альтернативная сортировка пузырьком");
                Console.WriteLine("4. Выход");
                var o = Console.ReadLine();
                int op = Convert.ToInt32(o);
                switch (op)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Введите 24 числа");
                            for (int i = 0; i < numbers.Length; i++)
                            {
                                Console.Write("{0}-е число: ", i + 1);
                                numbers[i] = double.Parse(Console.ReadLine());
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Возникла ошибка,вы ввели не число");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Обычная сортировка");
                        try
                        {
                            Console.WriteLine("Введите направление сортировки чисел");
                            Console.WriteLine("1. По невозрастанию");
                            Console.WriteLine("2. По неубыванию");
                            int Start = int.Parse(Console.ReadLine());


                            if (Start == 1)
                            {

                                double b;
                                for (int i = -1; i < numbers.Length; i++)
                                {
                                    for (int j = i + 1; j < numbers.Length; j++)
                                    {
                                        if (numbers[i] > numbers[j])
                                        {
                                            b = numbers[i];
                                            numbers[i] = numbers[j];
                                            numbers[j] = b;
                                        }
                                    }
                                }

                                // вывод
                                Console.WriteLine("Вывод отсортированного массива");

                                {
                                    Console.WriteLine("[{0}]", string.Join(", ", numbers));
                                }
                                Console.ReadLine();
                            }
                            else if (Start == 2)
                            {
                                // сортировка
                                double t;
                                for (int i = 0; i < numbers.Length - 1; i++)
                                {
                                    for (int j = i + 1; j < numbers.Length; j++)
                                    {
                                        if (numbers[i] < numbers[j])
                                        {
                                            t = numbers[i];
                                            numbers[i] = numbers[j];
                                            numbers[j] = t;
                                        }
                                    }
                                }
                                Console.WriteLine("Вывод отсортированного массива");

                                {
                                    Console.WriteLine("[{0}]", string.Join(", ", numbers));
                                }
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Введенно неизвестное действие");
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Такой команды не существует");
                        }               
                        break;
                    case 3:
                        try
                        {
                                for (int k = 0; k < 6; k++)     
                                {
                                    double z;
                                    for (int i = 0; i < 4; i++)
                                    {
                                        for (int j = i + 1; j < 4; j++)
                                            if (((k % 2 == 0) && (numbers[k * 4 + i] > numbers[k * 4 + j])) || ((k % 2 != 0) && (numbers[k * 4 + i] < numbers[k * 4 + j])))
                                            {

                                                z = numbers[k * 4 + i];
                                                numbers[k * 4 + i] = numbers[k * 4 + j];
                                                numbers[k * 4 + j] = z;
                                            }
                                    }
                                }
                                {

                                    Console.WriteLine("[{0}]", string.Join(", ", numbers));

                                }
                                Console.ReadLine();
                                break;
                        }
                        catch
                        {
                                Console.WriteLine("Возникла ошибка,вы не заполнили массив");
                        }
                        break;
                    case 4:

                        break;
                }
            }
        }
    }
}
