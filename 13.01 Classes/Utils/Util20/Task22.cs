using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task22
    {
        public double U { get; set; }
        public double Y { get; set; }
        public double X { get; set; }

        public Task22(double u, double y, double x)
        {
            U = u;
            Y = y;
            X = x;
        }

        public void Display()
        {
            double T = Math.Sin(2 * U) * Math.Log10(2 * Math.Pow(Y, 2 + Math.Sqrt(X)));
            Console.WriteLine(T);
        }
    }
}
