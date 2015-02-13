using System;
using System.Collections.Generic;

    class FindSum
    {
        //Write a program that finds in given array of integers a sequence of given sum S (if present).
        static void Main()
        {
            int[] arr = { 4, 3, 1, 4, 2, 5, 8, 2, 1 };

            //Check if all positive
            bool arePositive = true;
            foreach (var a in arr)
            {
                if (a <= 0)
                {
                    arePositive = false;
                    break;
                }
            }

            int sum = int.Parse(Console.ReadLine());


            if (arePositive)
            {
                //Declare a list to hold each element of the array
                List<int> arrList = new List<int>();
                int tempSum = 0;

                //Check each element before keeping it in the list
                for (int i = 0; i < arr.Length; i++)
                {
                    tempSum += arr[i];//find current sum
                    arrList.Add(arr[i]);//add next element to the list

                    //subtract first elements from the list until the current sum becomes less or equal to the required sum
                    if (tempSum > sum)
                    {
                        while (tempSum > sum)
                        {
                            tempSum -= arrList[0];
                            arrList.RemoveAt(0);
                        }
                    }

                    if (tempSum == sum)
                    {
                        Console.WriteLine("The sum {0} -> {1}", sum, string.Join(", ", arrList));
                        //return;
                    }
                }
            }

            else
            {
                //int iStart;
                //a loop for the start-index
                for (int i = 0; i < arr.Length; i++)
                {
                    int tempSum = 0;
                    //iStart = i;
                    //a loop for the end-index
                    for (int j = i; j < arr.Length; j++)
                    {
                        tempSum += arr[j];
                        if (tempSum == sum)
                        {
                            //create an array with lenght equal to the difference between the start-index and the end-index
                            int[] arrSum = new int[j - i + 1];
                            for (int k = 0; k < arrSum.Length; k++)
                            {
                                arrSum[k] = arr[i + k];
                            }
                            Console.WriteLine("The sum {0} -> {1}", sum, string.Join(", ", arrSum));
                        }
                    }
                }
            }
        }
    }