using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PTBac1
    {
        public double a { get; set; }
        public double b { get; set; }
        public double x { get; set; }

        public double Giai()
        {
            if (a == 0)
                if (b == 0)
                    throw new Exception("Phương trình vô sô nghiệm");
                else
                    throw new Exception("Phương trình vô nghiệm");
            x = -b / a;
            return -b / a;
        }

    }
}
