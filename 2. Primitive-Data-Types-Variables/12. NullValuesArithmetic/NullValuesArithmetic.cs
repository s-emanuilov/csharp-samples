using System;

    class NullValuesArithmetic
    {
        static void Main()
        {
            //Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.
            Console.Title = "ConsoleApp - Null values arithmetic ";
            int? intVar = null;
            double? doubleVar = null;
            Console.WriteLine("Print Variables assinged with null:\nInt: {0}\nDouble: {1}", intVar, doubleVar);
            intVar = 2;
            doubleVar = 2.6;
            Console.WriteLine("Print Variables pre-assinged with numbers:\nInt: {0}\nDouble: {1}", intVar, doubleVar);
        }
    }

