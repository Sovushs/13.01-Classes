using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task20
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double K { get; set; }

        public Task20(double x, double y, double k)
        {
            X = x;
            Y = y;
            K = k;
        }

        public void Display()
        {
            double U = Math.Pow(Math.E, K + Y) + Math.Tan(X) * Math.Sqrt(Y);
            Console.WriteLine(U);
        }
    }
}
