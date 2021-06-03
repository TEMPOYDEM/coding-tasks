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
            int tries = 0;
            Console.WriteLine("//");
            while (tries < 1000)
            {
                Lottery();
                tries = tries + 1;
            }
            Console.WriteLine("cc");
            Console.ReadKey();
        }
        public static void Lottery()
        {
            var chance = new Random();
            double chance_known = chance.Next(2);

            while (chance_known == 0)
            {
                chance_known = chance.Next(2);
            }
            if (chance_known == 1)
            {
                bool door1 = true;
                bool door2 = false;
                bool door3 = false;
                bool[] Doors_Choice = { door1, door2, door3 };
                Console.WriteLine("Дверь 1 - приз", "Двери 2 и 3 - пусто");
            }
            else if (chance_known == 2)
            {
                bool door1 = false;
                bool door2 = true;
                bool door3 = false;
                bool[] Doors_Choice = { door1, door2, door3 };
                Console.WriteLine("Дверь 1 - пусто", "Дверь 2 - приз", "Дверь 3 - пусто"); 
            }
            else if (chance_known == 3)
            {
                bool door1 = false;
                bool door2 = false;
                bool door3 = true;
                bool[] Doors_Choice = { door1, door2, door3 };
                Console.WriteLine("Двери 1 и 2 - пусто", "Дверь 3 - приз");
            }
            else
            {
                bool[] chan = { true, true, true };
                Console.WriteLine(chan);
            }

        }
        static void Player_A()
        {
            try
            {
                var choice = false;

            }
            catch { }
        }
        static void Player_B()
        {
            var choice = false;
            return choice = door1;
        }
    }
}
