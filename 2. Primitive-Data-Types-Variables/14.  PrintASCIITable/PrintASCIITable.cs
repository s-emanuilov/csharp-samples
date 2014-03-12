using System;
using System.Text;

    class PrintASCIITable
    {
        static void Main()
        {
            //write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). 
            Console.Title = "ConsoleApp - PrintASCIITable";
            Console.BufferHeight = 256;
            for (int decimalVar = 0; decimalVar < 256; decimalVar++)
            {
                string hexValue = decimalVar.ToString("X");
                int decAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
                char charToShow = (char)decAgain;
                Console.WriteLine("Hex: {0} Dec: {1} Char: {2}", hexValue, decimalVar, charToShow);    
            }
        }
    }

