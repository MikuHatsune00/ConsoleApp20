using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        public delegate double Circle(double r);
        static void Main(string[] args)
        
        {
            double r = 5;
            Circle circle1 = Getr;
            circle1 += GetL;
            circle1 += GetS;
            circle1 += GetV;
            double r1 =circle1(r);
            

            Console.ReadKey();
        }
        static double Getr(double r)
        {
            Console.WriteLine(r);
            return r;

        }
        static double GetL(double r)
        {
            double L = 2 * Math.PI * r;
            Console.WriteLine(L);
            return L;
            
        }
        static double GetS(double r)
        {
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine(S);
            return S;
           
        }
        static double GetV(double r)
        {
            double V = (4 / 3) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine(V);
            return V;
           
        }
    }
}
