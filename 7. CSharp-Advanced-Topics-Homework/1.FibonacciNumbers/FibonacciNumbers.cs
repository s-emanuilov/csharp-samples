using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        //Define a method Fib(n) that calculates the nth Fibonacci number. 
        Console.WriteLine("Please enter a number \"n\":");
        int n = int.Parse(Console.ReadLine());
        Console.Write("The {0} member is: ", n);
        Fib(n);
        Console.ReadLine();
    }
    static void Fib(int n)
    {
        int[] fibonacci = new int[3] { 1, 1, 2 };
        if (n==0||n==1)
        {
            Console.Write("{0} ", fibonacci[n]);
        }
        else
        {
            for (int i = 1; i <= n-1; i++)
            {

                fibonacci[2] = fibonacci[0] + fibonacci[1];
                fibonacci[0] = fibonacci[1];
                fibonacci[1] = fibonacci[2];

            }
            Console.Write("{0} ", fibonacci[2]);
        }
    }
}

