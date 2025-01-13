using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task10
    {
        public double Y { get; set; }
        public double K { get; set; }
        public double X { get; set; }

        public Task10(double y, double k, double x)
        {
            Y = y;
            K = k;
            X = x;
        }

        public void Display()
        {
            double U = Math.Pow(Math.E, Y) + 7.355 * Math.Pow(K, 2) + Math.Pow(Math.Sin(X), 2);
            Console.WriteLine(U);
        }
    }
}
