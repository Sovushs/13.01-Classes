using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task24
    {
        public double Y { get; set; }

        public Task24(double y)
        {
            Y = y;
        }

        public void Display()
        {
            double F = 2 * Math.Sin(0.214 * Math.Pow(Y, 5) + 1);
            Console.WriteLine(F);
        }
    }
}
