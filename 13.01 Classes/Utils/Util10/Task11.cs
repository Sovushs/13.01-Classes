using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task11
    {
        public double Y { get; set; }
        public double X { get; set; }

        public Task11(double y, double x)
        {
            Y = y;
            X = x;
        }

        public void Display()
        {
            double S = 9.756 * Math.Pow(Y, 7) + 2 * Math.Tan(X);
            Console.WriteLine(S);
        }
    }
}
