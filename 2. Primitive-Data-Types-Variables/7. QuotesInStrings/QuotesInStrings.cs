using System;

    class QuotesInStrings
    {
        static void Main()
        {
            Console.Title = "ConsoleApp - Quotes in strings";
            string firstStringVar = "The \"use\" of quotations causes difficulties.";
            string secondStringVar = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine("First String: {0}\nSecond String: {1}", firstStringVar, secondStringVar);
        }
    }

