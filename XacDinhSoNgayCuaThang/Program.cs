using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XacDinhSoNgayCuaThang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap thang: ");
            int thang = int.Parse(Console.ReadLine());

            if (thang == 2)
            {
                Console.Write("Nhap nam: ");
                int nam = int.Parse(Console.ReadLine());

                if (nam % 4 == 0 && nam % 100 > 0)
                    Console.WriteLine("Co 29 ngay");
                else
                    Console.WriteLine("Co 28 ngay");
            }
            else
            {
                switch (thang)
                {
                    case 1: Console.WriteLine("31 Ngay");
                        break;
                    case 3:
                        Console.WriteLine("31 Ngay");
                        break;
                    case 4:
                        Console.WriteLine("30 Ngay");
                        break;
                    case 5:
                        Console.WriteLine("31 Ngay");
                        break;
                    case 6:
                        Console.WriteLine("30 Ngay");
                        break;
                    case 7:
                        Console.WriteLine("31 Ngay");
                        break;
                    case 8:
                        Console.WriteLine("31 Ngay");
                        break;
                    case 9:
                        Console.WriteLine("30 Ngay");
                        break;
                    case 10:
                        Console.WriteLine("31 Ngay");
                        break;
                    case 11:
                        Console.WriteLine("30 Ngay");
                        break;
                    case 12:
                        Console.WriteLine("31 Ngay");
                        break;
                    default: Console.WriteLine("Khong co thang nay" +
                        "");
                        break;
                }

                switch (thang)
                {
                    case 1:
                    case 2:
                    case 3:
                        Console.WriteLine("Mua Xuan");
                        break;
                    case 4:
                    case 5:
                    case 6:
                        Console.WriteLine("Mua Ha");
                        break;
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("Mua Thu");
                        break;
                    case 10:
                    case 11:
                    case 12:
                        Console.WriteLine("Mua Dong");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
