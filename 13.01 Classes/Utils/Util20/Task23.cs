using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task23
    {
        public double Y { get; set; }

        public Task23(double y)
        {
            Y = y;
        }

        public void Display()
        {
            double G = Math.Pow(Math.E, 2 * Y) + Math.Sin(Y);
            Console.WriteLine(G);
        }
    }
}
