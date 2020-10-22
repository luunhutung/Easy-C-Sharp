using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            int kq = rng.Next(0, 9);
            Console.WriteLine("Random number: " + kq);
            Console.WriteLine("----- Ban co 3 luot -----");
            int turn = 0;
            while (true)
            {
                Console.Write("Turn {0} - Input number: ", turn + 1);
                int number = int.Parse(Console.ReadLine());

                if (number == kq)
                {
                    Console.WriteLine("Ban da doan dung");
                    break;
                }
                else
                    turn = turn + 1;

                if (turn == 3)
                {
                    Console.WriteLine("Ban da het luot");
                    break;
                }
            }
        }
    }
}
