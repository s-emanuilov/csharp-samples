using System;

class CalculateEquation
{
    static void Main()
        {
            //Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
            Console.Title = "ConsoleApp - Calculate Equation";
            Console.WriteLine("Please give the integer \"n\":");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give the integer \"x\":");
            int x = int.Parse(Console.ReadLine());
            double result = 1;
            int nFact=1;
            int xPower=1;
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
                xPower *= x;
                result += ((double)nFact) / xPower;
            }
            Console.WriteLine("Output: {0:F5}", result);
            Console.ReadLine();
        }
}

