using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multilevel_Inheritance
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
    class C : B
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
            Console.WriteLine("Multi Level Inheritance");
            C obj = new C();
            Console.WriteLine("a = {0}",obj.a);
            Console.WriteLine("b = {0}",obj.b);
            Console.WriteLine("c = {0}",obj.c);

            Console.ReadKey();

        }
    }
}
