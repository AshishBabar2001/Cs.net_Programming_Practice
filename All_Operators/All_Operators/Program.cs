using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace All_Operators
{
    class Program
    {
        int X, Y, Z;
        public void read()
        {
            Console.WriteLine("Enter Two No For Operation : ");
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());
        }
        public void Arithematic()
        {
            Z = X + Y;
            Console.WriteLine("Addition Is {0} : ",Z);
            Z = X - Y;
            Console.WriteLine("SubStraction Is {0} : ",Z);
            Z = X * Y;
            Console.WriteLine("Multiplication Is {0}",Z);
            Z = X / Y;
            Console.WriteLine("DiviSion Is {0}",Z);
            Z = X % Y;
            Console.WriteLine("Remainder Is {0}",Z);
            Z = X++;
            Console.WriteLine("Increment Of First Number Is {0} :",Z);
            Z = X--;
            Console.WriteLine("Decrement Of First Number Is {0} :",Z);
            Console.ReadLine();
        }
        public void realation()
        {
            if (X == Y)
            {
                Console.WriteLine(X + " Is Equal To " + Y);
            }
            else
            {
                Console.WriteLine(X + " Is Not Equal To " + Y);
            }
            if (X < Y)
            {
                Console.WriteLine(X+ " Is Less Than " + Y);
            }
            else
            {
                Console.WriteLine(X + " Is Greater Than " + Y);
            }
            if (X <= Y)
            {
                Console.WriteLine(X + " Is Either Less Than Or Equal To " + Y);
            }
            else
            {
                Console.WriteLine(X + " Is Either Greater Than Or Equal To " + Y);
            }
        }
        public void bitwise()
        {
            int Z = 0;
            Z = X & Y;
            Console.WriteLine("Value Of Bitwise & Is {0} : ",Z);
            Z = X / Y;
            Console.WriteLine("Value Of Bitwise / Is {0} : ", Z);
            Z = X ^ Y;
            Console.WriteLine("Value Of Bitwise ^ Is {0} : ", Z);
            Z = ~X;
            Console.WriteLine("Value Of Bitwise ~ Is {0} : ", Z);
            Z = X << 2;
            Console.WriteLine("Value Of Bitwise << Is {0} : ", Z);
            Z = X >> 2;
            Console.WriteLine("Value Of Bitwise >> Is {0} : ", Z);
            Console.ReadLine();
        }
        public void Assignment()
        {
            Z = X + Y;
            Console.WriteLine("Value Of Z : {0} ", Z);
            Z += X;
            Console.WriteLine("Value Of Z : {0} ", Z);
            Z -= X;
            Console.WriteLine("Value Of Z : {0} ", Z);
            Z /= X;
            Console.WriteLine("Value Of Z : {0} ", Z);
            Z *= X;
            Console.WriteLine("Value Of Z : {0} ", Z);
            Z %= X;
            Console.WriteLine("Value Of Z : {0} ", Z);
        }
        class Operator
        {
             static void Main(string[] args)
             {
                 Program P = new Program();
                 int Ch,i=1;
                 while (i == 1)
            	{
	                Console.WriteLine("**************Operator***************");
                    Console.WriteLine("1.Arithematic Operation");
                    Console.WriteLine("2.Relational Operation");
                    Console.WriteLine("3.Bitwise Operation");
                    Console.WriteLine("4.Assignment Operation");
                    Console.WriteLine("5.Exit");
                    Console.WriteLine("*************************************");
                    Console.WriteLine("Enter Your Choice");
                    Ch = Convert.ToInt32(Console.ReadLine());

                     switch(Ch)
                     {
                         case 1:
                             P.read();
                             P.Arithematic();
                             break;
                         case 2:
                             P.read();
                             P.realation();
                             break;
                         case 3:
                             P.read();
                             P.bitwise();
                             break;
                         case 4:
                             P.read();
                             P.Assignment();
                             break;
                         case 5:
                             Console.WriteLine("Exit");
                             Environment.Exit(-1);
                             break;
                         default:
                             Console.WriteLine("Wrong Choice");
                             break;
                     }
                     Console.WriteLine("Press Enter To Continue !!!");
                     Console.ReadLine();
	            }

             }

        }
    }
}
