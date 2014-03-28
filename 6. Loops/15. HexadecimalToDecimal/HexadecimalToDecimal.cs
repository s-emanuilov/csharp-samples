using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        //Using loops write a program that converts a hexadecimal integer number to its decimal form. The input is entered as string. The output should be a variable of type long. Do not use the built-in .NET functionality. 
        Console.Title = "ConsoleApp - Binary to decimal";
        Console.WriteLine("Please enter a hecadecimal number:");
        string hexadecimal = Console.ReadLine();
        long power = 1;
        int hex = 0;
        long result = 0;
        for (int i = 0; i < hexadecimal.Length; i++)
        {
            for (int j = 0; j < (hexadecimal.Length - 1) - i; j++)
            {
                power *= 16;
            }
            switch (hexadecimal[i])
            {
                case '0':
                    hex = 0;
                    break;
                case '1':
                    hex = 1;
                    break;
                case '2':
                    hex = 2;
                    break;
                case '3':
                    hex = 3;
                    break;
                case '4':
                    hex = 4;
                    break;
                case '5':
                    hex = 5;
                    break;
                case '6':
                    hex = 6;
                    break;
                case '7':
                    hex = 7;
                    break;
                case '8':
                    hex = 8;
                    break;
                case '9':
                    hex = 9;
                    break;
                case 'A':
                    hex = 10;
                    break;
                case 'B':
                    hex = 11;
                    break;
                case 'C':
                    hex = 12;
                    break;
                case 'D':
                    hex = 13;
                    break;
                case 'E':
                    hex = 14;
                    break;
                case 'F':
                    hex = 15;
                    break;

                default: hex = 0;
                    break;
            }

            result += hex * power;
            power = 1;
        }
        Console.WriteLine("Decimal: {0}", result);
        Console.ReadLine();
    }
}

