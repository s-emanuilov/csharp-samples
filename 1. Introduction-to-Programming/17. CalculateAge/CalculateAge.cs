using System;

    class CalculateAge
    {
        static void Main()
        {
            //Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
            Console.Title = "ConsoleApp - Calculate your age in 10 years";
            Console.WriteLine("Please enter year of born: (number between 1950 and 2010): ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the month, when you was born: (number between 1 and 12): ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the day, when you was born: (number between 1 and 31): ");
            int day = int.Parse(Console.ReadLine());
            int currentAge = DateTime.Now.Year - year;

            
            if (month > DateTime.Now.Month)
            {              
                currentAge = currentAge - 1;
                Console.WriteLine("Your age is: {0}, age in ten years: {1} ", currentAge, currentAge + 10);
            } else if (month == DateTime.Now.Month && day > DateTime.Now.Day)
            {
                currentAge = currentAge - 1;
                Console.WriteLine("Your age is: {0}, age in ten years: {1} ", currentAge, currentAge + 10);
            } else if (month == DateTime.Now.Month && day == DateTime.Now.Day)
            {
                Console.WriteLine("Happy Birthday!");
                Console.WriteLine("Your age is: {0}, age in ten years: {1} ", currentAge, currentAge + 10);
            } else
            {
                Console.WriteLine("Your age is: {0}, age in ten years: {1} ", currentAge, currentAge + 10);
            }
        }
    }

