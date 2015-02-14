using System;

class MaximalSum
{
    //Write a program that finds the sequence of maximal sum in given array.
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 7 };

        int maxSum = arr[0];//do not initialise as 0, because it won't work if all numbers are negative
        int start = 0;
        int end = 0;

        //advance the position through the entire array
        for (int i = 0; i < arr.Length; i++)
        {
            int tempSum = arr[i];

            for (int j = i + 1; j < arr.Length; j++)
            {
                tempSum += arr[j];
                if (tempSum >= maxSum)
                {
                    maxSum = tempSum;
                    start = i;
                    end = j;
                }
            }
        }
        Console.WriteLine("first index: {0} (value: {1}), last index: {2} (value:{3}), total sum: {4}", start, arr[start], end, arr[end], maxSum);
    }
}