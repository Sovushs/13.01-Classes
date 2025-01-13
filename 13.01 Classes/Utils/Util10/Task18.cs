using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util10
{
    public class Task18
    {
        public double Y { get; set; }

        public Task18(double y)
        {
            Y = y;
        }

        public void Display()
        {
            double Z = 3 * Math.Pow(Y, 2) + Math.Sqrt(Math.Pow(Y, 3) + 1);
            Console.WriteLine(Z);
        }
    }

}
