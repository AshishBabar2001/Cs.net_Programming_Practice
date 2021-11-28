using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herachical_Inheritace
{
        class A
        {
            public int a;
            public A()
            {
                a = 10;
            }
        }
        class B : A
        {
            public int b;
            public B()
            {
                b = 7;
            }
        }
        class C : A
        {
            public int c;
            public C()
            {
                c = 23;
            }
        }

        class Program
        {
        static void Main(string[] args)
        {
            Console.WriteLine("Herachical Inheritance");
            B obj = new B();
            C obj2 = new C();
            Console.WriteLine("Using Class B Object (obj)");
            Console.WriteLine("a = {0}",obj.a);
            Console.WriteLine("b = {0}",obj.b);
            Console.WriteLine("Using Class C Object (obj2)");
            Console.WriteLine("a = {0}",obj2.a);
            Console.WriteLine("c = {0}",obj2.c);

            Console.ReadKey();
        }
    }
}
