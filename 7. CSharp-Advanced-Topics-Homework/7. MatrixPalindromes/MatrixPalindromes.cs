using System;

class MatrixPalindromes
    {
        static void Main()
        {
            //Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns:
            Console.Title = "ConsoleApp - Matrix of Palindromes";
            Console.WriteLine("Please enter rows \"r\":");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter colums \"c\":");
            int cols = int.Parse(Console.ReadLine());
            int[,] palindromes = new int[rows, cols];
            int startChar = 97;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write((char)(startChar+i));
                    Console.Write((char)(startChar + i+j));
                    Console.Write((char)(startChar + i));
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

