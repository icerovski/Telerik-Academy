using System;

    class AllocateArray
    {
        //Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
        static void Main()
        {
            int[] arr = new int[20];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine("Arr [{0}] = {1}", i, arr[i]);
            }

        }
    }