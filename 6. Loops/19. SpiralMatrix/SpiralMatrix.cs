using System;

class SpiralMatrix
{
    static void Main()
    {
        //Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below. 
        Console.Title = "ConsoleApp - Spiral Matrix";
        Console.WriteLine("Please enter a number \"n\" (1 ≤ n ≤ 20): ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0;
        int col = 0;
        int number = 1;

        for (int i = 1; i <= n * n; i++)
        {

            while (true)
            {
                matrix[row, col] = number;
                if (col + 1 < n && matrix[row, col + 1] == 0)
                {
                    ++col;
                    ++number;
                }
                else break;
            }
            while (true)
            {
                matrix[row, col] = number;
                if (row + 1 < n && matrix[row + 1, col] == 0)
                {
                    ++row;
                    ++number;
                }
                else break;
            }
            while (true)
            {
                matrix[row, col] = number;
                if (col - 1 >= 0 && matrix[row, col - 1] == 0)
                {
                    --col;
                    ++number;
                }
                else break;
            }
            while (true)
            {
                matrix[row, col] = number;
                if (row - 1 >= 0 && matrix[row - 1, col] == 0)
                {
                    --row;
                    ++number;
                }
                else break;
            }
        }

        for (int r = 0; r < n; r++)
        {
            for (int c = 0; c < n; c++)
            {
                Console.Write("{0,2} ", matrix[r, c]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
