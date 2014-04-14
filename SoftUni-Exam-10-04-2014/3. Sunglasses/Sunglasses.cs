using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //top
        Console.Write(new string('*', 2 * n));
        Console.Write(new string(' ', n));
        Console.Write(new string('*', 2 * n));
        Console.WriteLine();

        //middle
        int middle = (n - 2) / 2;
        for (int i = 0; i < n - 2; i++)
        {
            if (i == middle)
            {
                //ramka
                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.Write('*');
                Console.Write(new string('|', n));
                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.Write('*');
            }
            else
            {
                // ne ramka
                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.Write('*');
                Console.Write(new string(' ', n));
                Console.Write('*');
                Console.Write(new string('/', 2 * n - 2));
                Console.Write('*');
            }
            Console.WriteLine();
        }

        //bottom
        Console.Write(new string('*', 2 * n));
        Console.Write(new string(' ', n));
        Console.Write(new string('*', 2 * n));

        Console.ReadLine();
    }
}

