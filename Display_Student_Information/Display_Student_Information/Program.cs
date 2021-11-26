using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display_Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            int S = 5;
            string[] Std_Name = new string[S];
            string[] Std_Class = new string[S];
            int[] Roll_No = new int[S];
            double[] Mob_No = new double[S];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Your Roll No");
                Roll_No[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Name");
                Std_Name[i] = Console.ReadLine();
                Console.WriteLine("Enter Your Mobile No.");
                Mob_No[i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Your Class");
                Std_Class[i] = Console.ReadLine();
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("***** Student Details *****");
                Console.WriteLine(" ");
                Console.WriteLine("Student Roll_No = {0}",Roll_No[i]);
                Console.WriteLine("Student Name = {0}",Std_Name[i]);
                Console.WriteLine("Student Mob_No = {0}",Mob_No[i]);
                Console.WriteLine("Student Class = {0}",Std_Class[i]);

                Console.ReadKey();
            }
        }
    }
}
