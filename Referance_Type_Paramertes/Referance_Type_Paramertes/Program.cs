using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Referance_Type_Paramertes
{
    class Program
    {
        public static void Value(int Num)
        {
            Num++;
        }
        public static void Reference(ref int Num)
        {
            Num++;
        }
        static void Main(string[] args)
        {
            int Num;
            Console.WriteLine("Enter The Number");
            Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Value Type : ");
            Console.WriteLine("Previous Value : \t{0}",Num);
            Program.Value(Num);
            Console.WriteLine("\n Current Value : \t{0}",Num);
            Console.WriteLine("\n Reference Type:");
            Console.WriteLine("Previous Value : \t{0}",Num);
            Program.Reference(ref Num);
            Console.WriteLine("\n Current Value : \t{0}",Num);
            Console.ReadLine();
        }
    }
}
