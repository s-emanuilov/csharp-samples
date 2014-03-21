using System;

class SumNumbers
    {
        static void Main()
        {
            //Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. 
            Console.Title = "ConsoleApp - Sum of 5 numbers";
            Console.WriteLine("Important! You have to use the right decimal separator for your system!");
            Console.WriteLine("Plese enter 5 number on a single line, sepatate by space:");
            string numbers = Console.ReadLine();
            string[] explode = numbers.Split(" ".ToCharArray());
            Console.WriteLine("The sum of the numbers is: {0}", Convert.ToDouble(explode[0]) + Convert.ToDouble(explode[1]) + Convert.ToDouble(explode[2]) + Convert.ToDouble(explode[3]) + Convert.ToDouble(explode[4]));
            Console.ReadLine();
        }
    }

