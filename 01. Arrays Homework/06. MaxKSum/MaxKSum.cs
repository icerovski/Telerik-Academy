using System;
using System.Linq;

    class MaxKSum
    {
        //Write a program that reads two integer numbers N and K and an array of N elements from the console. Find in the array those K elements that have maximal sum.
        static void Main()
        {
            //Type in numbers separated by SPACE
            string[] numbersString = Console.ReadLine().Split(' ');
            int[] numbers = new int[numbersString.Length];
            for (int i = 0; i < numbersString.Length; i++)
            {
                numbers[i] = int.Parse(numbersString[i]);
            }

            //Initialise n as the length of the array
            int n = numbers.Length;
            
            //Type in size of sequence
            int k = int.Parse(Console.ReadLine());

            //Check sums of the sequence
            int maxSum = 0;
            for (int i = 0; i < n - k + 1; i++)
            {
                int tempSum = 0;
                for (int j = i; j < k + i; j++)
                {
                    tempSum += numbers[j];
                }
                if (tempSum >= maxSum)
                {
                    maxSum = tempSum;
                }
            }
            Console.WriteLine("The largest sum is: {0}", maxSum);
        }
    }