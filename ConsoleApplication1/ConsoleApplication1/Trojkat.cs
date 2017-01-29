using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Trojkat : Ksztalt
    {

        public Trojkat() : base()
        {

        }

        public Trojkat(double a, double b, double c) : base()
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double ObliczObwod()
        {
            return a + b + c;
        }

        public override double ObliczPole()
        {
            double p = ObliczObwod() / 2.0;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }
    }
}
