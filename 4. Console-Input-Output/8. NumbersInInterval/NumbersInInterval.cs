﻿using System;

    class NumbersInInterval
    {
        static void Main()
        {
            //Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop. 
            Console.Title = "ConsoleApp - Numbers in interval";
            Console.WriteLine("Please enter integer \"n\" (the end of the interval):");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }

