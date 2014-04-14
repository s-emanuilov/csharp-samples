using System;

class HalfSum
{
    static void Main(string[] args)
    {
        long n = int.Parse(Console.ReadLine());
        long sumOfFirst = 0;
        long sumfOfLast = 0;
        for (int i = 0; i < n; i++)
        {
            long number = long.Parse(Console.ReadLine());
            sumOfFirst += number;
        }
        for (int j = 0; j < n; j++)
        {
            long number1 = long.Parse(Console.ReadLine());
            sumfOfLast += number1;
        }

        //check if equal
        if (sumOfFirst == sumfOfLast)
        {
            Console.WriteLine("Yes, sum={0}", sumfOfLast);
        }

        //check if first is bigger, the result must be positive!
        else if (sumOfFirst > sumfOfLast)
        {
            Console.WriteLine("No, diff={0}", sumOfFirst - sumfOfLast);
        }

        //check if second is bigger, the result must be positive!
        else if (sumOfFirst < sumfOfLast)
        {
            Console.WriteLine("No, diff={0}", sumfOfLast - sumOfFirst);
        }
        else
        {
            Console.WriteLine("No, diff=0");
        }
        Console.ReadLine();
    }
}
