using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task3
    {
        public double N { get; set; }
        public double Y { get; set; }

        public Task3(double n, double y)
        {
            N = n;
            Y = y;
        }

        public void Display()
        {
            double G = N * (Y + 3.5) + Math.Sqrt(Y);
            Console.WriteLine(G);
        }
    }
}
