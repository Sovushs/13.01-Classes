using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._01_Classes.Utils.Util20
{
    public class Task28
    {
        public double V { get; set; }

        public Task28(double v)
        {
            V = v;
        }

        public void Display()
        {
            double W = Math.Pow(Math.Sin(V), 2) - Math.Pow(V, 2);
            Console.WriteLine(W);
        }
    }
}
