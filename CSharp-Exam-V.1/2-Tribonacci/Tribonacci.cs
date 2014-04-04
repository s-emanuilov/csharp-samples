using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

class Tribonacci
{
    static void Main()
    {

        BigInteger first = BigInteger.Parse(Console.ReadLine());
        BigInteger second = BigInteger.Parse(Console.ReadLine());
        BigInteger third = BigInteger.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        BigInteger result = new BigInteger();

        if (n == 1 || n == 2 || n == 3)
        {
            switch (n)
            {
                case 1: Console.WriteLine(first);
                    break;
                case 2: Console.WriteLine(second);
                    break;
                case 3: Console.WriteLine(third);
                    break;
                default:
                    break;
            }
        }
        else
        {
            for (int i = 0; i < n-3; i++)
            {
                result= first + second + third;
                first = second;
                second = third;
                third = result;
            }
            Console.Write(result);
        }
        Console.ReadLine();
    }
}


