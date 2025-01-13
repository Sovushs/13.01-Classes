using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util10
{
    public class Task12
    {
        public double T { get; set; }
        public double X { get; set; }

        public Task12(double t, double x)
        {
            T = t;
            X = x;
        }

        public void Display()
        {
            double K = 7 * Math.Pow(T, 2) + 3 * Math.Pow(Math.Sin(X), 3) + 9.2;
            Console.WriteLine(K);
        }
    }
}
