using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util10
{
    public class Task14
    {
        public double Y { get; set; }
        public double X { get; set; }

        public Task14(double y, double x)
        {
            Y = y;
            X = x;
        }

        public void Display()
        {
            double R = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(Y), 2) + 6.835) + Math.Pow(Math.E, X));
            Console.WriteLine(R);
        }
    }
}
