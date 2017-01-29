using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ksztalt> figury = new List<Ksztalt>();
            figury.Add(new Trojkat(12, 5, 8));
            figury.Add(new Trojkat(10, 2, 5));
            figury.Add(new TrojkatProstokatny(16, 7));
            figury.Add(new TrojkatProstokatny(12, 3));
            figury.Add(new TrojkatRownoboczny(12));
            figury.Add(new Trojkat(11, 5, 8));
            figury.Add(new TrojkatProstokatny(12, 9));
            figury.Add(new TrojkatRownoboczny(17));
            figury.Add(new TrojkatRownoboczny(11));
            figury.Add(new TrojkatProstokatny(12, 7));

            foreach (Ksztalt f in figury)
            {
                if (f.ObliczPole() > 10)
                    Console.WriteLine(f);
            }

            foreach(Ksztalt f in figury)
            {
                if (f.ObliczObwod() >= 20.0)
                    Console.WriteLine(f);
            }

            Console.WriteLine();
            Console.WriteLine("Zadanie 9:");
            
            figury.Add(new Prostokat(12, 7));
            figury.Add(new Prostokat(11, 9));
            figury.Add(new Kwadrat(12));
            figury.Add(new Kwadrat(5));
            figury.Add(new Prostokat(5, 7));
            figury.Add(new Kwadrat(7));
            figury.Add(new Prostokat(12, 14));
            figury.Add(new Kwadrat(16));
            figury.Add(new Prostokat(16, 9));
            figury.Add(new Kwadrat(13));

            foreach (Ksztalt f in figury)
            {
                double p = f.ObliczPole();
                if (p > 12.0 && p < 24.0)
                    Console.WriteLine(f);
            }

            Console.ReadKey();
        }
    }
    
}
