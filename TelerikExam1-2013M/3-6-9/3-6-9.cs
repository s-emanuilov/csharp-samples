using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        long a = long.Parse(Console.ReadLine());
        uint b = uint.Parse(Console.ReadLine());
        long c = long.Parse(Console.ReadLine());
        BigInteger result = 0;
        switch (b)
        {
            case 3: result = a + c;
                break;
            case 6: result = a * c;
                break;
            case 9: result = a % c;
                break;
            default: Console.WriteLine("Wrong secret code!");
                break;
        }

        if (result % 3 == 0)
        {
            Console.WriteLine(result / 3);
            Console.WriteLine(result);
        }
        else if (result % 3 != 0)
        {
            Console.WriteLine(result % 3);
            Console.WriteLine(result);  
        }

        Console.ReadLine();

    }
}

