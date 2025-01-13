using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task2
    {
        public double P { get; set; }
        public double Y { get; set; }

        public Task2(double p, double y)
        {
            P = p;
            Y = y;
        }

        public void Display()
        {
            double K = Math.Log10(Math.Pow(P, 2) + Math.Pow(Y, 3)) + Math.Pow(Math.E, P);
            Console.WriteLine(K);
        }
    }
}
