using System;

class CalculateEquation
{
    static void Main()
    {
        //Calculate N! / K!
        Console.Title = "ConsoleApp - Calculate Equation N! / K!";
        Console.WriteLine("Please give the integer \"n\" 1 < k < n < 100:");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Please give the integer \"k\" 1 < k < n < 100:");
        int k = int.Parse(Console.ReadLine());
        int nFact = 1;
        int kFact = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i <= k)
            {
                kFact *= i;
            }
            nFact *= i;
        }
        Console.WriteLine("Output: {0}", nFact / kFact);
        Console.ReadLine();
    }
}

