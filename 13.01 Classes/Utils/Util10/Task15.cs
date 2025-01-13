using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util10
{
    public class Task15
    {
        public double Y { get; set; }

        public Task15(double y)
        {
            Y = y;
        }

        public void Display()
        {
            double H = Math.Pow(Math.Sin(Y), 2) - 2.8 * Y + Math.Sqrt(Math.Abs(Y));
            Console.WriteLine(H);
        }
    }
}
