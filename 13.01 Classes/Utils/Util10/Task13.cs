using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util10
{
    public class Task13
    {
        public double Y { get; set; }

        public Task13(double y)
        {
            Y = y;
        }

        public void Display()
        {
            double E = Math.Sqrt(Math.Abs(3 * Math.Pow(Y, 2) + 0.5 * Y + 4));
            Console.WriteLine(E);
        }
    }
}
