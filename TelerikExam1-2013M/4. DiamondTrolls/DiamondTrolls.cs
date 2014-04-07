using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DiamondTrolls
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = ((n + 1) / 2) - 1;
        int innerDots = ((n + 1) / 2) - 1;

        Console.Write(new string('.', (n + 1) / 2));
        Console.Write(new string('*', n));
        Console.Write(new string('.', (n + 1) / 2));
        Console.WriteLine();
        for (int i = 0; i < n / 2; i++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.Write(new string('.', outerDots));
            outerDots--;
            innerDots++;
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', 2 * n + 1));
        outerDots = 1;
        innerDots--;
        for (int g = 0; g < n-1; g++)
        {
            Console.Write(new string('.', outerDots));
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.Write(new string('.', innerDots));
            Console.Write('*');
            Console.Write(new string('.', outerDots));
            outerDots++;
            innerDots--;
            Console.WriteLine();
        }
        Console.Write(new string('.', n));
        Console.Write('*');
        Console.Write(new string('.', n));

        Console.ReadLine();
    }
}

