using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Phuong trinh bac 2");

            float a, b, c, delta;

            Console.Write("Nhap a:");
            a = float.Parse(Console.ReadLine());

            Console.Write("Nhap b:");
            b = float.Parse(Console.ReadLine());

            Console.Write("Nhap c:");
            c = float.Parse(Console.ReadLine());

            if (a == 0)
                Console.WriteLine("Day khong phai la phuong trinh bac 2. Hay thu lai");
            else
            {
                delta = b * b - 4 * a * c;

                if (delta < 0)
                    Console.WriteLine("Phuong trinh vo nghiem");
                else
                    Console.WriteLine("Phuong trinh co 2 nghiem x1 = {0} va x2 = {1}", (-b + Math.Sqrt(delta)) / 2 * a, (-b - Math.Sqrt(delta)) / 2 * a);
            }
        }
    }
}
