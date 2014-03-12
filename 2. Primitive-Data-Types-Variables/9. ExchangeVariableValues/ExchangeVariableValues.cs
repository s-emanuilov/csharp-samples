using System;

    class ExchangeVariableValues
    {
        static void Main()
        {
            //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values. Print the variable values before and after the exchange.
            Console.Title = "ConsoleApp - Exchange variable values";
            int a = 5;
            int b = 10;
            int median = a;
            Console.WriteLine("Variable a = {0}\nVariable b = {1}", a,b);
            a = b;
            b = median;
            Console.WriteLine("Exchanged value of a = {0}\nExchanged value of b = {1}", a, b);
        }
    }

