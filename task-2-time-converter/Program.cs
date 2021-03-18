using System;
using System.Globalization;
namespace task_2_time_converter
{
    class Operations
    {
        
        public double ConvertDaysToHours(double number)
        {
                double h = number * 24;
                return h;
        }

        public double ConvertHoursToMinutes(double num)
        {

            double min = num * 60;
            return min;                    
        }
        public double ConvertMinutesToSeconds(double num)
        {

            double sec = num * 60;
            return sec;
        }
        public double ConvertSecondsToMinutes(Int32 num)
        {

            double a = num * 0.1;
            double b = 60 * 0.1;
            double min = a / b;
            return min;
        }
        public double ConvertMinutesToHours(Int32 num)
        {
            double a = num * 0.1;
            decimal b = (decimal)(60 * 0.1);
            double v = Convert.ToDouble(b);
            double h = a / v;
            return h;
        }
        public double ConvertHoursToDays(Int32 num)
        {
            double a = num * 0.1;
            decimal b = (decimal)(24 * 0.1);
            double v = Convert.ToDouble(b);
            double d = a / v;
            return d;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Operations op = new Operations();

            double dth = op.ConvertDaysToHours(4);                    //конвертировать дни в часы
            Console.WriteLine("4 days in hours is " +dth);          //результат: 96

            double htm = op.ConvertHoursToMinutes(3);                 //конвертировать часы в минуты
            Console.WriteLine("3 hours in minutes is " + htm);      //результат: 180

            double mts = op.ConvertMinutesToSeconds(2);               //конвертировать минуты в секунды
            Console.WriteLine("2 minutes in seconds is " + mts);    //результат: 120

            double stm = op.ConvertSecondsToMinutes(42);           //конвертировать секунды в минуты
            Console.WriteLine("42 seconds in minutes is " + stm);   //результат: 0.7

            double mth = op.ConvertMinutesToHours(108);            //конвертировать минуты в часы
            Console.WriteLine("108 minutes in hours is " + mth);    //результат: 1.8

            double htd = op.ConvertHoursToDays(90);                //конвертировать часы в дни
            Console.WriteLine("90 hours in days is " + htd);         //результат: 3.75

                double dts = op.ConvertMinutesToSeconds(
                              op.ConvertHoursToMinutes(
                               op.ConvertDaysToHours(0.451)));    //конвертировать дни в секунды
              Console.WriteLine("0.451 days in seconds is " + dts);   //результат: 38966.4
            


            Console.ReadKey();                                 //пауза
        }
    }
}