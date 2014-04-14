using System;
using System.Text;

class BitsInverter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int step = int.Parse(Console.ReadLine());
        string binary = "";
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            binary += Convert.ToString(number, 2).PadLeft(8, '0');
        }
        StringBuilder newBinary = new StringBuilder();
        newBinary.Append(binary);
        int position = 0;
        for (int j = 0; j < (binary.Length / step) + 1; j++)
        {
            if (newBinary[position] == '0')
            {
                newBinary[position] = '1';
            }
            else if (newBinary[position] == '1')
            {
                newBinary[position] = '0';
            }
            position += step;
            if (position >= binary.Length)
            {
                break;
            }
        }
        int counter = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(Convert.ToInt32(newBinary.ToString().Substring(counter, 8), 2));
            counter += 8;
        }
    }
}

