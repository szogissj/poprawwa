using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Ksztalt
    {
        protected double a;
        protected double b;
        protected double c;
        protected double d;

        public Ksztalt()
        {

        }

        public abstract double ObliczPole();
        public abstract double ObliczObwod();

        public override string ToString()
        {
            return "Obwod: " + ObliczObwod() + ", Pole: " + ObliczPole();
        }

    }
}
