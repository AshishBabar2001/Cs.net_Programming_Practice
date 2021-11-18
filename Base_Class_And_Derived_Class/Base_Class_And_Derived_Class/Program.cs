using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Base_Class_And_Derived_Class
{
    class A
    {
        public int a;
        public A()
        {
            a = 5;
        }
    }
    class B : A
    {
        public int b;
        public B()
        {
            b = 20; 
        }
        public int getsum()
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            B Obj = new B();
            Console.WriteLine("Sum = {0} ",Obj.getsum());
            Console.ReadKey();
        }
    }
}
