using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util10
{
    public class Task19
    {
        public double N { get; set; }
        public double Y { get; set; }
        public double G { get; set; }

        public Task19(double n, double y, double g)
        {
            N = n;
            Y = y;
            G = g;
        }

        public void Display()
        {
            double P = N * Math.Sqrt(Math.Pow(Y, 3) + 1.09 * G);
            Console.WriteLine(P);
        }
    }
}
