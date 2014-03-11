using System;

    class PrintingSequence
    {
        static void Main()
        {
            //Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
            Console.Title = "ConsoleApp - Printing a sequence";
          
            for (int counter = 2; counter < 12; counter++)
            {
                if (counter % 2 == 0) 
                {
                    Console.WriteLine(counter);
                } else
                {
                    Console.WriteLine(-counter);
                }
                
            }
        }
    }

