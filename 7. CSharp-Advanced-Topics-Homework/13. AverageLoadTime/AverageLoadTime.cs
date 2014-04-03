using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;

class AverageLoadTime
{
    static void Main()
    {
        //We have a report that holds dates, web site URLs and load times (in seconds) in the 
        //same format like in the examples below. Your tasks is to calculate the average load 
        //time for each URL. Print the URLs in the same order as they first appear in the input 
        //report. Print the output in the format given below. Use double floating-point precision.
        //We have a report that holds dates, web site URLs and load times (in seconds) in the same
        //format like in the examples below. Your tasks is to calculate the average load time for 
        //each URL. Print the URLs in the same order as they first appear in the input report.
        //Print the output in the format given below. Use double floating-point precision. 
        Console.Title = "ConsoleApp - Avarage Load Time";
        Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
        List<string> inputStrings = new List<string> {"2014-Apr-01 02:01 http://softuni.bg 8.37725",
"2014-Apr-01 02:05 http://www.nakov.com 11.622",
"2014-Apr-01 02:06 http://softuni.bg 4.33",
"2014-Apr-01 02:11 http://www.google.com 1.94",
"2014-Apr-01 02:11 http://www.google.com 2.011",
"2014-Apr-01 02:12 http://www.google.com 4.882",
"2014-Apr-01 02:34 http://softuni.bg 4.885",
"2014-Apr-01 02:36 http://www.nakov.com 10.74",
"2014-Apr-01 02:36 http://www.nakov.com 11.75",
"2014-Apr-01 02:38 http://softuni.bg 3.886",
"2014-Apr-01 02:44 http://www.google.com 1.04",
"2014-Apr-01 02:48 http://www.google.com 1.4555",
"2014-Apr-01 02:55 http://www.google.com 1.977"
};
        Dictionary<string, double> result = new Dictionary<string, double>();
        Dictionary<string, int> resultCounter = new Dictionary<string, int>();
        for (int i = 0; i < inputStrings.Count; i++)
        {
            int counter = 1;
            string[] splitInputString = inputStrings[i].Split(' ');

            if (!result.ContainsKey(splitInputString[2]))
            {
                string input = splitInputString[2].Trim();
                result.Add(input, double.Parse(splitInputString[3]));
                resultCounter.Add(splitInputString[2], counter);

            }
            else
            {
                result[splitInputString[2]] += double.Parse(splitInputString[3]);
                resultCounter[splitInputString[2]] += 1;
            }
        }
        var keysList = result.Keys.ToList();
        foreach (var key in keysList)
        {
            Console.Write("{0} -> {1}\n\r", key, result[key] / resultCounter[key]);
        }
        Console.ReadLine();
    }
}
