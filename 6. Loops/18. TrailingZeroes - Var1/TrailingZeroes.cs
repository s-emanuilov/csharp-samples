using System;

class TrailingZeroes
{
    static void Main()
    {
        //Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000. 
        Console.Title = "ConsoleApp - Calculates with how many zeroes the factorial of a given number";
        Console.WriteLine("Please enter a number \"n\":");
        int n = int.Parse(Console.ReadLine());
        int k = 0;
        int power = 5;
        double result = 0;
        while (power < n)
        {
            power *= 5;
            k++;
        }
        power = 1;
        for (int i = 0; i < k; i++)
        {
            power *= 5;
            result += n / power;
        }
        Console.WriteLine("The Trailing Zeroes are: {0} ",result);
        Console.ReadLine();
    }
}