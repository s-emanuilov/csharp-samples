using System;
using System.Numerics;

class CalculateEquation
{
    static void Main()
    {
        //Calculate N! / (K! * (N-K)!)
        Console.Title = "ConsoleApp - Calculate N! / (K! * (N-K)!)";
        Console.WriteLine("Please give the integer \"n\" 1 < k < n < 100:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please give the integer \"k\" 1 < k < n < 100:");
        int k = int.Parse(Console.ReadLine());
        BigInteger nFact = 1;
        BigInteger kFact = 1;
        BigInteger nMinKFact = 1;
        for (int i = 1; i <=n; i++)
        {
            if (i<=(n-k))
            {
                nMinKFact *= i;
            }
            if (i<=k)
            {
                kFact *= i;
            }
            nFact *= i;
        }
        Console.WriteLine("Output: {0}",nFact/(kFact*nMinKFact));
        Console.ReadLine();
    }
}

