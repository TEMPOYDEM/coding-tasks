using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace task_6_monty_hall_problem
{



    class Program
    {

        static void Main(string[] args)
        {
            Lottery();
            Console.ReadKey();
        }
        public static void Lottery()
        {
            double winrate = 0;
            int tries = 0;
            var chance = new Random();
            var Monty = new Random();
            var winning_options = new List<bool> { };
            double wins_A = 0;
            double wins_B = 0;
            bool door1 = false;
            bool door2 = false;
            bool door3 = false;
            bool A = false;
            bool B = false;
            while (tries < 1000)
            {
                int chance_known = chance.Next(4);
                while (chance_known == 0)
                {
                    chance_known = chance.Next(4);
                }
                if (chance_known == 1)
                {
                    door1 = true;
                    door2 = false;
                    door3 = false;
                    // Console.WriteLine("Дверь 1 - приз  " + "Двери 2 и 3 - пусто");
                }
                else if (chance_known == 2)
                {
                    door1 = false;
                    door2 = true;
                    door3 = false;
                    //Console.WriteLine("Дверь 1 - пусто  " + "Дверь 2 - приз  " + "Дверь 3 - пусто");

                }
                else if (chance_known == 3)
                {
                    door1 = false;
                    door2 = false;
                    door3 = true;
                    //Console.WriteLine("Двери 1 и 2 - пусто  " + "Дверь 3 - приз")
                }
                List<bool> Doors_Choice = new List<bool> { door1, door2, door3 };
                int losedoor = Monty.Next(1,3);
                bool winopen = Doors_Choice.ElementAt(losedoor);
                while (winopen == true)
                {
                    try
                    {
                        losedoor++;
                        winopen = Doors_Choice.ElementAt(losedoor);
                    }
                    catch
                    {
                        losedoor = losedoor-2;
                        winopen = Doors_Choice.ElementAt(losedoor);
                    }
                }
                A = Doors_Choice.ElementAt(0);
                if(A == true)
                {
                    wins_A++;
                }
                int i = 1;
                if (i == losedoor)
                {
                    i++;
                }
                B = Doors_Choice.ElementAt(i);
                if (B == true)
                {
                    wins_B++;
                }
                tries++;
            }
            Console.WriteLine(wins_A);
            Console.WriteLine(wins_B);
            winrate = wins_A / 1000;
            Console.WriteLine("Процент побед Алисы:  " + winrate*100);
            Console.ReadKey();
            
            winrate = wins_B / 1000;
            
            Console.WriteLine("Процент побед Боба:  " + winrate*100);
            Console.ReadKey();

        }
    }
}

