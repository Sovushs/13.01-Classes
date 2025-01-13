using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task9
    {
        public double Y { get; set; }
        public double X { get; set; }

        public Task9(double y, double x)
        {
            Y = y;
            X = x;
        }

        public void Display()
        {
            double V = Math.Log10(Y + 0.95) + Math.Pow(Math.Sin(X), 4);
            Console.WriteLine(V);
        }
    }
}
