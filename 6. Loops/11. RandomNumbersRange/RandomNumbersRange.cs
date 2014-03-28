using System;

class RandomNumbersRange
{
    static void Main()
        {
            //Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max]. 
            Console.Title = "ConsoleApp - Print \"n\" random numbers in range";
            Console.WriteLine("Please enter \"max\" of the interval:");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine(("Please enter \"min\" of the interval:"));
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter \"n\" random numbers for show:");
            int n =int.Parse(Console.ReadLine());
            Random rand=new Random();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",rand.Next(min, max+1));   
            }
            Console.ReadLine();
        }
}

