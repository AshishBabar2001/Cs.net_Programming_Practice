using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, Rev = 0, R, N1;
            Console.WriteLine("Enter Any Number");
            N = Convert.ToInt32(Console.ReadLine());
            N1 = N;
            while (N > 0)
            {
                R = N % 10;
                Rev = Rev * 10 + R;
                N = N / 10;
            }
            if (N1 == Rev)
            {
                Console.WriteLine("Number Is Palindrome");
            }
            else
            {
                Console.WriteLine("Number Is Not Palindrome");
            }
            Console.ReadKey();
        }
    }
}
