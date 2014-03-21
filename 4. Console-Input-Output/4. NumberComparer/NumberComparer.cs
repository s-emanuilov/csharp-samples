using System;

    class NumberComparer
    {
        static void Main()
        {
            //Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. 
            Console.Title = "ConsoleApp - Print the bigger number";
            Console.WriteLine("Please enter the first number:");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number:");
            double secondNum = double.Parse(Console.ReadLine());
            Console.WriteLine("{0} is greater than {1}", Math.Max(firstNum,secondNum), Math.Min(firstNum,secondNum));
            Console.ReadLine();
        }
    }

