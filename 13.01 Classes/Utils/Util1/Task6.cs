using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task6
    {
        public double Y { get; set; }
        public double X { get; set; }

        public Task6(double y, double x)
        {
            Y = y;
            X = x;
        }

        public void Display()
        {
            double M = Math.Cos(2) * Y + 3.6 * Math.Pow(Math.E, X);
            Console.WriteLine(M);
        }
    }
}
