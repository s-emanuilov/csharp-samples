using System;

class FormattingNumbers
{
    static void Main()
    {
        //Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), 
        //a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. 
        //Each column should have a width of 10 characters. The number a should be printed in hexadecimal, 
        //left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, 
        //right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. 

        Console.Title = "ConsoleApp - Formating Numbers";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter integer \"a\" (0<=a<=500):");
        int a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Please enter float \"b\":");
        double b = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter float \"c\":");
        double c = Double.Parse(Console.ReadLine());
        Console.WriteLine("{0,-10:X}|{1}|{2,10:F2}|{3,-10:F3}|", a, Convert.ToString(a,2).PadLeft(10, '0'),b, c);
        Console.ReadLine();
    }
}

