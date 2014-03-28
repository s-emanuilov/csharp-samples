using System;

class RandomizeNumbers
{
    static void Main()
    {
        //Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order. 
        Console.Title = "ConsoleApp - Randomize the numbers";
        Console.WriteLine("Please enter \"n\" random numbers for show:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random rand = new Random();
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; ; j++)
            {
                int randMoment = rand.Next(0, n);
                if (numbers[randMoment] == 0)
                {
                    numbers[randMoment] = i;
                    break;
                }
            }

        }
        Console.WriteLine("Output:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.ReadLine();
    }
}

