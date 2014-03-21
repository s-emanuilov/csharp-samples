using System;

class SumIntegers
{
    static void Main()
        {
            //Write a program that reads 3 integer numbers from the console and prints their sum.
            Console.Title = "ConsoleApp - Calculate sum of 3 numbers";
            Console.WriteLine("Important! You have to use the right decimal separator for your system!");
            Console.WriteLine("Please enter the first number:");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter the second number:");
            string second = Console.ReadLine();
            Console.WriteLine("Please enter the third number:");
            string third = Console.ReadLine();
            double firstDouble, secondDouble, thirdDouble;
            if (Double.TryParse(first, out firstDouble) && Double.TryParse(second, out secondDouble)&&Double.TryParse(third, out thirdDouble))
            {
                double sum = firstDouble+secondDouble+thirdDouble;
                Console.WriteLine("{0} + {1} + {2} = {3}",firstDouble,secondDouble,thirdDouble,sum);
            }
            else
            {
                Console.WriteLine("Invalid data!");
            }
        Console.ReadLine();
        }
}
