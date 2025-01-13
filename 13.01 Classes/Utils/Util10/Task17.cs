using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util10
{
    public class Task17
    {
        public double Y { get; set; }

        public Task17(double y)
        {
            Y = y;
        }

        public void Display()
        {
            double N = 3 * Math.Pow(Y, 2) + Math.Sqrt(Y + 1);
            Console.WriteLine(N);
        }
    }
}
