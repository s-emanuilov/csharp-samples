using System;

class OddEvenProduct
{
    static void Main()
    {
        //You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 
        Console.Title = "ConsoleApp - product of the odd elements and of the even elements";
        Console.WriteLine("Please give some integers in single line, separated by a space");
        string inputNums = Console.ReadLine();
        string[] numbers = inputNums.Split(' ');
        int productOdd = Convert.ToInt32(numbers[0]);
        int productEven = Convert.ToInt32(numbers[1]);
        //numbers[numbers.Length + 1] = " 1";
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                if ((i + 2) < numbers.Length)
                {
                    productOdd *= Convert.ToInt32(numbers[i + 2]);

                }
                else
                {
                    productOdd *= 1;
                }
            }
            else
            {
                if ((i + 2) < numbers.Length)
                {
                    productEven *= Convert.ToInt32(numbers[i + 2]);
                }
                else
                {
                    productEven *= 1;
                }
            }
        }
        if (productOdd == productEven)
        {
            Console.WriteLine("yes\n\rproducts is: {0}", productOdd);
        }
        else
        {
            Console.WriteLine("no\n\rProduct odd = {0}\n\rProduct even = {1}", productOdd, productEven);
        }
        Console.ReadLine();

    }
}

