using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._02._23__dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector a= new Vector();
            Vector b= new Vector(1);
            Vector c= new Vector(1,2,4);
            c.PrintVector();
            Console.WriteLine();
            a.InputVector();
            Console.WriteLine();
            Console.WriteLine(c.VectorLength());
            Console.WriteLine();
            c.Increase(12);
            c.PrintVector();
            c.Decrease(3);
            c.PrintVector();
            Console.WriteLine();
            c = a + b;
            c.PrintVector();
            Console.WriteLine();
            a = b * c;
            a.PrintVector();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            a.PrintVector();
            Console.WriteLine();
            c.PrintVector();
            Console.WriteLine(c != a);
            Console.WriteLine("\n\n\tBYE!\n\n");
        }
    }
}
