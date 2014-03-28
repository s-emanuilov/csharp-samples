using System;
using System.Numerics;

class CatalanNumbers
    {
        static void Main()
        {
            //Write a program to calculate the nth Catalan number by given n (1 < n < 100). 
            Console.Title = "ConsoleApp -Catalan number by given n";
            Console.WriteLine("Please give the integer \"n\" 1 < k < n < 100:");
            int n = int.Parse(Console.ReadLine());
            BigInteger nFactDouble = 1;
            BigInteger nFactDoubleBig = 1;
            BigInteger nFact = 1;
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
                nFactDoubleBig *= (n + i);
                nFactDouble = nFact * nFactDoubleBig;
            }
            Console.WriteLine("Output: {0}", nFactDouble/(nFact*(n+1)*nFact));
            Console.ReadLine();
        }
    }

