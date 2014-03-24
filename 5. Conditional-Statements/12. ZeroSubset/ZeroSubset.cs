using System;

class ZeroSubset
{
    static void Main()
    {
        //We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0. Assume that repeating the same subset several times is not a problem. 
        Console.Title = "ConsoleApp - Zero Subset";
        Console.WriteLine("Please enter a number \"a\":");
        int[] numbers = new int[5];
        numbers[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"b\":");
        numbers[1] = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"c\":");
        numbers[2] = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"d\":");
        numbers[3] = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"e\":");
        numbers[4] = int.Parse(Console.ReadLine());
        int counter = 0;
        if (numbers[0] == 0 && numbers[1] == 0 && numbers[2] == 0 && numbers[3] == 0 && numbers[4] == 0)
        {
            Console.WriteLine("0 + 0 + 0 + 0 + 0 = 0");
            Console.WriteLine("Subsets: 32");
        }
        else
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (numbers[i] + numbers[k] == 0)
                    {
                        Console.WriteLine("{0} + {1} = 0", numbers[i], numbers[k]);
                        counter++;
                    }
                    for (int j = k + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] + numbers[k] + numbers[j] == 0)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", numbers[i], numbers[k], numbers[j]);
                            counter++;
                        }
                        for (int g = j + 1; g < numbers.Length; g++)
                        {
                            if (numbers[i] + numbers[k] + numbers[j] + numbers[g] == 0)
                            {
                                Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[i], numbers[k], numbers[j], numbers[g]);
                                counter++;
                            }
                            for (int q = g + 1; q < numbers.Length; q++)
                            {
                                if (numbers[i] + numbers[k] + numbers[j] + numbers[g] + numbers[q] == 0)
                                {
                                    Console.WriteLine("{0} + {1} + {2} + {3} +{4} = 0", numbers[i], numbers[k], numbers[j], numbers[g], numbers[q]);
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Subsets: {0}", counter);
        }

        Console.ReadLine();
    }
}

