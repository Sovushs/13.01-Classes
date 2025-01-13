using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task4
    {
        public double A { get; set; }
        public double T { get; set; }

        public Task4(double a, double t)
        {
            A = a;
            T = t;
        }

        public void Display()
        {
            double D = 9.8 * Math.Pow(A, 2) + 5.52 * Math.Pow(Math.Cos(T), 5);
            Console.WriteLine(D);
        }
    }
}
