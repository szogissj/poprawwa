using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class TrojkatProstokatny : Trojkat
    {

        public TrojkatProstokatny() : base()
        {

        }

        public TrojkatProstokatny(double a, double b) : base(a, b, Math.Sqrt(a*a+b*b))
        {

        }

    }
}
