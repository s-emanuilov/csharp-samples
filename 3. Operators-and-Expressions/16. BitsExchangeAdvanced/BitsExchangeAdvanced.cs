using System;

class BitsExchangeAdvanced
{
    static void Main()
    {
        //Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. 
        Console.Title = "ConsoleApp - BitsExchangeAdvanced";
        Console.WriteLine("Please enter your number: ");
        uint num = uint.Parse(Console.ReadLine());
        Console.WriteLine("Please enter \"p\":");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter \"q\": ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter \"k\": ");
        int k = int.Parse(Console.ReadLine());

        int[] bits = new int[32];
        int[] resultBits = new int[32];
        uint nRight;
        for (int i = 0; i < 32; i++)
        {
            nRight = num >> i;
            if ((nRight & 1) == 1)
            {
                bits[i] = 1;
                resultBits[i] = 1;
            }
            else
            {
                bits[i] = 0;
                resultBits[i] = 0;
            }
        }
        if (((p + (k - 1)) >= 32) || ((q + (k - 1)) >= 32))
        {
            Console.WriteLine("Out of range!");
        }
        else if ((Math.Max(p, q) - Math.Min(p, q)) <= (k - 1))
        {
            Console.WriteLine("Overlapping!");
        }
        else
        {
            for (int i = 0; i < k; i++)
            {
                resultBits[p] = bits[q];
                resultBits[q] = bits[p];
                p++;
                q++;
            }

            string result = "";
            for (int i = 0; i < 32; i++)
            {
                result = Convert.ToString(resultBits[i]) + result;
            }
            Console.WriteLine("Input: {0}\nbitwise: {1}\n", num, Convert.ToString(num, 2).PadLeft(32, '0'));
            Console.WriteLine("Output: {0}\nbitwise: {1}", Convert.ToUInt32(result, 2), result);
        }


        Console.ReadLine();
    }
}

