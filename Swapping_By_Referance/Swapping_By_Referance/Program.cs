using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_By_Referance
{
    class Program
    {
        static void Swap(ref int X, ref int Y)
        {
            int t = X;
            X = Y;
            Y = t;
        }
        static void Main(string[] args)
        {
            int a = 50, b = 40;
            Console.WriteLine("Value Of a And b Before Swapping");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);

            Swap(ref a,ref b);
            Console.WriteLine("Value Of a And b After Swapping");
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = "+b);
            Console.ReadKey();
        }
    }
}
