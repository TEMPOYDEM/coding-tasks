using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task_1_calculator
{
    class Operations
    {

        public double Addition(double number1, double number2)
        {
            double num;
            num = number1 + number2;
            return num;
        }

        public double Substraction(double number1, double number2)
        {
            double num;
            num = number1 - number2;
            return num;
        }

        public double Multiplication(double number1, double number2)
        {
            double num;
            return num = number1 * number2;
        }

        public double Division(double number1, double number2)
        {
            double num;
            return num = number1 / number2;
        }
    }
    class Program
    {

        private static void Main(string[] args)
        {
            while (true)
            {
                Operations operation = new Operations();
                Console.WriteLine("Здравствуйте! Вы запустили программу калькулятор. Сейчас Вам потребуется ввести требуемые программой данные");



                Console.WriteLine("Введите первое число и нажмите Enter");
                try
                {
                    string number1_1 = Console.ReadLine();

                    double number1 = Convert.ToDouble(number1_1);

                    Console.WriteLine("Введите необходимую операцию: * = умножение , - = вычитание , + = сложение , / = деление, любое число = возведение числа в степень, равную введенному числу, и нажмите Enter.");
                    var a = Console.ReadLine();
                    try
                    {
                        double c = Convert.ToDouble(a);
                        double result = Math.Pow(number1, c);
                        Console.WriteLine(result);

                    }
                    catch {
                            Console.WriteLine("Введите второе число и нажмите Enter");
                            string number2_1 = Console.ReadLine();
                            double number2 = Convert.ToDouble(number2_1);


                            if (a == "*")
                            {
                                double result = operation.Multiplication(number1, number2);
                                Console.WriteLine(result);
                            }
                            else if (a == "-")
                            {
                                double result = operation.Substraction(number1, number2);
                                Console.WriteLine(result);
                            }
                            else if (a == "+")
                            {
                                double result = operation.Addition(number1, number2);
                                Console.WriteLine(result);
                            }
                            else if (a == "/")
                            {
                                double result = operation.Division(number1, number2);
                                Console.WriteLine(result);
                            }
                    }

                    
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Деление на ноль невозможно");
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели не число");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Недопустимая операция");
                    Console.ReadLine();
                }
                Console.WriteLine("Нажмите любую клавишу для продолжения");
                Console.ReadKey();
            }
        }
    }
}