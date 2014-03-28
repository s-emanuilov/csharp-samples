using System;

class CalculateGCD
{
    static void Main()
    {
        //Write a program that calculates the greatest common divisor (GCD) of given two integers a and b. Use the Euclidean algorithm 
        Console.Title = "ConsoleApp - Calculate Greater Common Divider";
        Console.WriteLine("Please give an integer \"a\":");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Please give an integer \"b\":");
        int b = int.Parse(Console.ReadLine());
        int gcd = 0;
        int checkA = a;
        int checkB = b;
        for (int i = 0; ; i++)
        {

            if (checkB == 0)
            {
                gcd = checkA;
                break;
            }
            else
            {
                gcd = checkA;
                checkA = checkB;
                checkB = gcd % checkB;
            }

        }
        Console.WriteLine("GCD: {0:}", gcd);
        Console.ReadLine();
    }
}

