using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        Eulers eu = new Eulers();
        static void Main(string[] args)
        {
            Program p = new Program();
            p.MultipleThreeFive();
            p.Fibonacci();

            Console.ReadKey();
            
        }

        public void MultipleThreeFive()
        {
            Console.WriteLine(eu.MultipleThreeFive());
        }

        public void Fibonacci()
        {
            Console.WriteLine(eu.Fibbonaci());
        }
    }
}
