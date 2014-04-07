using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TheHorror
{
    static void Main()
    {
        string text = Console.ReadLine();
        decimal sum=0;
        decimal fal = 0;
        decimal counter = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (i%2==0)
            {
                string str = text[i].ToString();
                if (decimal.TryParse(str, out fal))
                {
                    sum+= decimal.Parse(str);
                    counter++;             
                }
            } 
        }
        Console.WriteLine(counter+" "+sum);
        Console.ReadLine();
    }
}
