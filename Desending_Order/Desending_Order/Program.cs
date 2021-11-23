using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Desending_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[10];
            int i, j, k,t;
            Console.WriteLine("Enter Elements In Array");
            for (i = 0; i <= 9; i++)
            {
                A[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i <= 9; i++)
            {
                for (j = 0; j <= 9; j++)
                {
                    if (A[i] < A[j])
                    {
                       t = A[i];
                       A[i] = A[j];
                       A[j] = t;
                    }
                }
            }
            Console.WriteLine("Asending Order");
            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine(+A[i]);
            }
            for (i = 0; i <= 9; i++)
            {
                for (j = 0; j <= 9; j++)
                {
                    if (A[i] > A[j])
                    {
                        t = A[i];
                        A[i] = A[j];
                        A[j] = t;
                    }
                }
            }
            Console.WriteLine("Desending Order");
            for (i = 0; i <= 9; i++)
            {
                Console.WriteLine(+A[i]);
            }
            Console.ReadLine();
        }
    }
}
