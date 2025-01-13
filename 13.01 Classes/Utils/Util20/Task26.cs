using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task26
    {
        public double P { get; set; }

        public Task26(double p)
        {
            P = p;
        }

        public void Display()
        {
            double Z = Math.Pow(Math.Sin(Math.Pow(P, 2) + 0.4), 3);
            Console.WriteLine(Z);
        }
    }
}
