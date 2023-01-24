using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace product1
{
    internal class product
    {
        // Addition
        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Addition(int a, int b, int c)
        {
            return a % b - c;
        }
        public int Addition(int a, int b, int c, int d)
        {
            return a % b * c + d;
        }
        public double Addition(int a, double b)
        {
            return a + b;
        }
        public double Addition(double a, int b)
        {
            return a + b;
        }
        public double Addition(float a, double b)
        {
            return a + b;
        }

    }
}
