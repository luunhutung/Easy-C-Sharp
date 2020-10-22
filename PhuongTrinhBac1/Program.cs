using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------Phuong trinh bac nhat----------");

            float a, b;

            Console.Write("+ Nhap a: ");
            a = float.Parse(Console.ReadLine());

            Console.Write("+ Nhap b: ");
            b = float.Parse(Console.ReadLine());
            
            if (b < 0)
                Console.WriteLine("Phuong trinh: {0}x{1}=0", a, b);
            else
                Console.WriteLine("Phuong trinh: {0}x+{1}=0", a, b);

            if (a == 0)
                Console.WriteLine("==== Result: Phuong trinh vo nghiem ====");
            else if (a == 0 && b == 0)
                Console.WriteLine("==== Result: Phuong tringh vo so nghiem ====");
            else
                Console.WriteLine("==== Result: " + -b / a + " ====");
        }
    }
}
