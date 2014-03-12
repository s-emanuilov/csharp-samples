using System;

    class ComparingFloats
    {
        static void Main()
        {
            Console.Title = "ConsoleApp - Comparing floats";
            Console.Write("Please enter number (decimal separator is \",\"): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Please enter another number (decimal separator is \",\"): ");
            double b = double.Parse(Console.ReadLine());
         
           if ((Math.Max(a, b) - Math.Min(a, b)) < 0.000001)
           {
               Console.WriteLine("The numbers {0} and {1} are equal!", a, b);
           }
           else
           {
               Console.WriteLine("The numbers {0} and {1} are NOT equal!", a, b);
           }
        }
    }

