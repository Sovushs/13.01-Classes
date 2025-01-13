using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task29
    {
        public double X { get; set; }

        public Task29(double x)
        {
            X = x;
        }

        public void Display()
        {
            double G = 3.1 * Math.Pow(Math.Sin(X), 2) + 2.5 * Math.Pow(Math.Cos(X), 3);
            Console.WriteLine(G);
        }
    }
}
