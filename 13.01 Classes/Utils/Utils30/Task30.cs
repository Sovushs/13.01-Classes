using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Utils30
{
    public class Task30
    {
        public double X { get; set; }

        public Task30(double x)
        {
            X = x;
        }

        public void Display()
        {
            double P = Math.Log(X + 1) + 5 * Math.Pow(X, 3);
            Console.WriteLine(P);
        }
    }
}
