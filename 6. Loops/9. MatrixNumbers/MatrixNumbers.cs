using System;

    class MatrixNumbers
    {
        static void Main()
        {
            //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix. 
            Console.Title = "ConsoleApp - Matrix of Numbers";
            Console.WriteLine("Please give the integer \"n\" 1 < k < n < 20:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write((j+i)+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

