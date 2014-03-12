using System;

    class UnicodeValue
    {
        static void Main()
        {
            //Declare a character variable and assign it with the symbol that has Unicode code 72, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 72. The output should be “H”.
            Console.Title = "ConsoleApp - UnicodeValue";
            char characterVar='\u0048';
            Console.WriteLine("The symbol with Unicode code 72 is: {0}", characterVar);
        }
    }

