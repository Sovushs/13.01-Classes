using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils
{
    public class Task8
    {
        public double Y { get; set; }

        public Task8(double y)
        {
            Y = y;
        }

        public void Display()
        {
            double T = Math.Sqrt(Math.Abs(6 * Math.Pow(Y, 2) - 0.1 * Y + 4));
            Console.WriteLine(T);
        }
    }
}
