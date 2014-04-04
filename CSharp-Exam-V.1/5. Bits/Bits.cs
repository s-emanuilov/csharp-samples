using System;

class Bits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateReversedNum(number));
        }
        Console.ReadLine();
    }

    public static int CalculateReversedNum(int num)
    {
        string binary = Convert.ToString(num,2);
        char[] array = binary.ToCharArray();
        Array.Reverse(array);
        string result = new string(array);
        num = Convert.ToInt32(result, 2);
        return num;
    }
}

