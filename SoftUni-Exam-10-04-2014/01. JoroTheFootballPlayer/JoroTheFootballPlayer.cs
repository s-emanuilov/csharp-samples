using System;

class JoroFootball
{
    static void Main()
    {
        string t = Console.ReadLine();
        int p = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        double football = 0.5 * p + (((52 - h) * 2) / 3) + h;
        if (t == "t")
        {
            football += 3;
        }
        else if (t == "f")
        {

        }
        else
        {
            Console.WriteLine("something wrong");
        }
        Console.WriteLine(Convert.ToInt32(football));
        Console.ReadLine();
    }
}

