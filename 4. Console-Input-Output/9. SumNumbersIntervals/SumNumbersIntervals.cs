using System;

    class SumNumbersIntervals
    {
        static void Main()
        {
            //Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. 
            Console.Title = "ConsoleApp - Sum numbers in intervals";
            Console.WriteLine("Please enter a number \"n\":");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Please enter a number :");
                sum += double.Parse(Console.ReadLine()); ;
            }
            Console.WriteLine("Sum: {0}", sum);
            Console.ReadLine();
        }
    }

