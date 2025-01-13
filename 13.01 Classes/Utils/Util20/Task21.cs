using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task21
    {
        public double Y { get; set; }
        public double H { get; set; }

        public Task21(double y, double h)
        {
            Y = y;
            H = h;
        }

        public void Display()
        {
            double P = Math.Pow(Math.E, Y + 5.5) + 9.1 * Math.Pow(H, 3);
            Console.WriteLine(P);
        }
    }
}
