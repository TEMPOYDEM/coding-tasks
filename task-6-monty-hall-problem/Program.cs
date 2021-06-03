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
            Console.WriteLine("cc");
            var chance = new Random();
            var Monty = new Random();
            var winning_options = new List<int> { };
            bool door1 = false;
            bool door2 = false;
            bool door3 = false;
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
                    bool[] Doors_Choice = { door1, door2, door3 };
                   // Console.WriteLine("Дверь 1 - приз  " + "Двери 2 и 3 - пусто");
                }
                else if (chance_known == 2)
                {
                    door1 = false;
                    door2 = true;
                    door3 = false;
                    bool[] Doors_Choice = { door1, door2, door3 };
                    //Console.WriteLine("Дверь 1 - пусто  " + "Дверь 2 - приз  " + "Дверь 3 - пусто");
                }
                else if (chance_known == 3)
                {
                    door1 = false;
                    door2 = false;
                    door3 = true;
                    bool[] Doors_Choice = { door1, door2, door3 };
                    //Console.WriteLine("Двери 1 и 2 - пусто  " + "Дверь 3 - приз");
                }
                tries++;
                winning_options.Add(chance_known);
            }
            //Боб выбирает дверь 1, потом сделать так, чтобы Монти через рандом открывал дверь со значением false. Когда двеь открыта (удалена из массива методом pop), сделать смену варианта выбора. После этого в цикле while проверять условие bool, так как Бобу формата bool будет присваиваться значение t или f. В цикле организовать проверку на принадлежность к true. В случае совпадения через цикл if добавляется к wins++
            double winrate = 0;
            double wins = 0;
            foreach (int i in winning_options)
            {
                if(i == 1)
                {
                    wins++;
                }
            }
            winrate = wins / 1000;
            Console.WriteLine(wins);
            Console.WriteLine("Процент побед Алисы:  " + winrate * 100);
            Console.ReadKey();

            wins = 0;
            foreach (int i in winning_options)
            {
                if (i == 2 || i == 3)
                {
                    wins++;
                }
            }
            winrate = wins / 1000;
            Console.WriteLine(wins);
            Console.WriteLine("Процент побед Боба:  " + winrate * 100);
            Console.ReadKey();
        }
    }
}

