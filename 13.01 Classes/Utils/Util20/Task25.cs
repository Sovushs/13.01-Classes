using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task25
    {
        public double Y { get; set; }

        public Task25(double y)
        {
            Y = y;
        }

        public void Display()
        {
            double G = Math.Pow(Math.E, 2 * Y) + Math.Sin(Math.Pow(Y, 2));
            Console.WriteLine(G);
        }
    }
}
