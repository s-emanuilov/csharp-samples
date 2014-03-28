using System;

    class DecimalToBinary
    {
        static void Main()
        {
            //Using loops write a program that converts an integer number to its binary representation. The input is entered as long. The output should be a variable of type string. Do not use the built-in .NET functionality. 
            Console.Title = "ConsoleApp - Convert integer to binary";
            Console.WriteLine("Please enter a decimal number:");
            long num = long.Parse(Console.ReadLine());
            long division = num;
            string binary = "";
            for (int i = 0; i < 64; i++)
            {
                if (division%2==0)
                {
                    if (division<=1)
                    {
                        break;
                    }
                    binary = "0"+binary;
                    division /= 2;
                }
                else
                {
                    binary = "1"+binary;
                    division /= 2;
                }
            }
            Console.WriteLine("Binary output: {0}", binary);
            Console.ReadLine();
        }
    }
