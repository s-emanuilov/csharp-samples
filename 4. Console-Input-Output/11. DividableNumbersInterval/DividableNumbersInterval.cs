using System;

    class DividableNumbersInterval
    {
        static void Main()
        {
            //Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0. 
            Console.Title = "ConsoleApp - Get dividable by 5 numbers in interval";
            Console.WriteLine("Please enter the first positive integer:");
            int firstInt = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second positive integer:");
            int secondInt = Int16.Parse(Console.ReadLine());
            int counter = 0;
            string nums = "";
            for (int i = Math.Min(firstInt, secondInt); i <= Math.Max(firstInt, secondInt); i++)
            {
                if (i%5==0)
                {
                    counter++;
                    nums += Convert.ToString(i) + " ";
                }
            }
            Console.WriteLine("In the interval {0} to {1} there is {2} numbers, which can be deleted to 5 without reminder, they are: {3}", Math.Min(firstInt,secondInt), Math.Max(firstInt,secondInt), counter, nums);
            Console.ReadLine();
        }
    }

