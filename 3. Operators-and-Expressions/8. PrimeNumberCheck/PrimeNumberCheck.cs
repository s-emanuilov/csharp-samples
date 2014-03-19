using System;

class PrimeNumberCheck
{
    static void Main()
    {
        //Write an expression that checks if given positive integer number n (n ≤ 100) is prime.
        Console.Title = "ConsoleApp - Prime number check";
        Console.WriteLine("Please enter prime number (between 1 and 100):");
        int primeNum = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = 1; i <= primeNum; i++)
        {
            if (primeNum % i == 0)
            {
                counter++;
            }
        }
        
        if (counter == 2)
        {
            Console.WriteLine("The number that you have entered is PRIME!");
        }
        else
        {
            Console.WriteLine("The number that you have entered is NOT PRIME!");
        }
        Console.ReadLine();
    }
}
