using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingForLoop2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tong tu 1 -> n
            /*Console.Write("Input number: ");
            int number = int.Parse(Console.ReadLine());
            int result = 0;

            Console.Write("Tong tu 1 -> {0}: ", number);

            for (int i = 0; i <= number; i++)
            {
                result += i;
            }
            Console.WriteLine("Result: {0}", result);*/
            #endregion

            #region Tinh n!
            /*Console.Write("Input number: ");
            int number = int.Parse(Console.ReadLine());
            int result = 1;

            if (number == 0)
            {
                result = 1;
                Console.WriteLine("Result {0}!: {1}", number, result);
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                Console.WriteLine("Result {0}!: {1}", number, result);
            }*/
            #endregion

            #region Tong tu 1/1 -> 1/n
            Console.Write("Input number: ");
            int number = int.Parse(Console.ReadLine());

            double result = 0;

            Console.Write("Tong tu 1 -> 1/{0}: ", number);

            for (int i = 1; i <= number; i++)
            {
                result += 1.0 / (double)i;
            }

            Console.WriteLine("Result: {0}", result);
            #endregion

            #region Kiem tra nhap dung hay sai

            int songuyen;
            Console.Write("Nhap so nguyen: ");

            for (; ;)
            {
                bool kiemtra = int.TryParse(Console.ReadLine(), out songuyen);

                if (kiemtra == true)
                    break;
                else
                    Console.Write("Nhap lai so nguyen: ");
            }
            #endregion
        }
    }
}
