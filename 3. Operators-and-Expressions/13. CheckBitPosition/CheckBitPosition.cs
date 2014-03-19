using System;

    class CheckBitPosition
    {
        static void Main()
        {
            //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. 
            Console.Title = "ConsoleApp - Check bit at give position";
            Console.WriteLine("Please give a number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a position:");
            int p = int.Parse(Console.ReadLine());
            string numBitwise = Convert.ToString(n, 2);
            int nRight = n >> p;
            bool isOne = (nRight & 1) == 1;
            if (isOne)
            {
                Console.WriteLine("The bit on position {0} in the number {1} (bitwise: {2}) is 1? : {3}", p, n, numBitwise, isOne);
            }
            else
            {
                Console.WriteLine("The bit on position {0} in the number {1} (bitwise: {2}) is 1? : {3}", p, n, numBitwise, isOne);
            }
            Console.ReadLine();
        }
    }

