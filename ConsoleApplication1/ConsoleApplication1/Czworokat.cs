using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Czworokat : Ksztalt
    {

        public Czworokat() : base()
        {

        }
    
        public Czworokat(double a, double b, double c, double d) : base()
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public override double ObliczObwod()
        {
            return a + b + c + d;
        }

        public override double ObliczPole()
        {
            double p = ObliczObwod() / 2.0;
            return Math.Sqrt(p*(p-a) * (p - b) * (p - c) * (p - d));
        }
    }
}
