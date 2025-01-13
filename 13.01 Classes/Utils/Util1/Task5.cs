using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task5
    {
        public double X { get; set; }

        public Task5(double x)
        {
            X = x;
        }

        public void Display()
        {
            double L = 1.51 * Math.Pow(Math.Cos(X), 2) + 2 * Math.Pow(X, 3);
            Console.WriteLine(L);
        }
    }
}
