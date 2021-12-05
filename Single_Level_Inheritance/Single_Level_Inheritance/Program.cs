using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Single_Level_Inheritance
{
      class A
        {
            public int a;
            public A()
            {
                a = 10;
            }
        }
        class B: A
        {
            public int b;
            public B()
            {
                b = 7;
            }

        }

        class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Level Inheritance");
            B obj = new B();
            Console.WriteLine("a = {0}",obj.a);
            Console.WriteLine("b = {0}",obj.b);
            Console.ReadKey();
        }
    }
}
