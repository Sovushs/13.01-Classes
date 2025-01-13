using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task1
    {
        public double T { get; set; }
        public double L { get; set; }

        public Task1(double t, double l)
        {
            T = t;
            L = l;
        }

        public void Display()
        {
            Console.Clear();

            double R = 3 * Math.Pow(T, 2) + 3 * Math.Pow(L, 5) + 4.9;

            Console.WriteLine(R);
        }
        
    }
}
