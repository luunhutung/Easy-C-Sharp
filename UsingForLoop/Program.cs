using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            #region For Loop
            /*for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.Write("{0} Xin chào | ", i);
            }*/
            #endregion

            #region Xuat So Chan
            /*Console.Write("Input a number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Cac so chan tu 0 -> {0}: ", number);

            for (int i = 0; i <= number; i++)
                if (i % 2 == 0)
                    Console.Write("{0} ", i);

            Console.Write("\n");*/
            #endregion

            #region Bang Cuu Chuong
            /*Console.WriteLine("Ban cuu chuong");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }
                Console.WriteLine("==========");
            }*/
            #endregion

            #region Xuat Bang Cuu Chuong 1 So

            Console.Write("Nhap so: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Ban cuu chuong cua {0}", number);

            for (int i = 1; i <= 10; i++)
                    Console.WriteLine("{0} x {1} = {2}", number, i, number * i);
            #endregion
        }
    }
}
