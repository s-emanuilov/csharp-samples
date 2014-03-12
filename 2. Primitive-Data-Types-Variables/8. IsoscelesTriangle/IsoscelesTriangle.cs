using System;
using System.Text;
    class IsoscelesTriangle
    {
        static void Main()
        {
            //Write a program that prints an isosceles triangle of 9 copyright symbols ©, 
            Console.Title = "ConsoleApp - Isosceles Triangle";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char copyrightSign = '©';
            Console.WriteLine("   " + copyrightSign + "   ");
            Console.WriteLine("  " + copyrightSign + " "+copyrightSign);
            Console.WriteLine(" " + copyrightSign+"   "+copyrightSign);
            for (int i = 0; i <4; i++)
            {
                Console.Write(copyrightSign+" ");
            }
            Console.WriteLine();
        }
    }

