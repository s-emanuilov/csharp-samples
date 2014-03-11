using System;

    class PrintLongSequence
    {
        static void Main()
        {
            //Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
            Console.Title = "ConsoleApp - Printing a Long sequence";
            Console.BufferHeight = 1001;
            for (int counter = 2; counter < 1002; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                else
                {
                    Console.WriteLine(-counter);
                }

            }
        }
    }

