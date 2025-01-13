using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util10
{
    public class Task16
    {
        public double Y { get; set; }

        public Task16(double y)
        {
            Y = y;
        }

        public void Display()
        {
            double S = Math.Sqrt(Math.Cos(4) * Math.Pow(Y, 2) + 7.151);
            Console.WriteLine(S);
        }
    }
}
