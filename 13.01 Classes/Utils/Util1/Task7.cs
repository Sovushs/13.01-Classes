using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task7
    {
        public double M { get; set; }

        public Task7(double m)
        {
            M = m;
        }

        public void Display()
        {
            double N = Math.Pow(M, 2) + 2.8 * Math.Abs(M) + 0.55;
            Console.WriteLine(N);
        }
    }
}
