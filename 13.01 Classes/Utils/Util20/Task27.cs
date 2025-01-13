using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task27
    {
        public double V { get; set; }
        public double Y { get; set; }
        public double X { get; set; }

        public Task27(double v, double y, double x)
        {
            V = v;
            Y = y;
            X = x;
        }

        public void Display()
        {
            double P = 9.7 * Math.Pow(Math.Sin(X), 2) + 2.5 * Math.Pow(Y, 3) + 4 * V;
            Console.WriteLine(P);
        }
    }
}
