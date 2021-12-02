using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pass_By_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 10, B = 20;
            int C;
            Console.WriteLine("Before Swapping Of Value A Is : "+A);
            Console.WriteLine("Before Swapping Of Value B Is : "+B);
            C = A;
            A = B;
            B = C;
            Console.WriteLine("\nAfter Swapping Value Of A Is : "+A);
            Console.WriteLine("After Swapping Value Of B Is : "+B);
            Console.ReadKey();
        }
    }
}
