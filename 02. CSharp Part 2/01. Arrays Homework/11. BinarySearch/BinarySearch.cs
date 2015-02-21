using System;

class BinarySearch
{
    //Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
    static void Main()
    {
        //Create a sorted ascending array
        int[] arr = { -1, 5, 6, 9, 10, 13, 17, 20, 21, 32, 35, 40 };
        int x = 6;

        int minIndex = 0;
        int maxIndex = arr.Length - 1;
        int midIndex = 0;

        do
        {
            //mid-point equals (iMax + iMin) / 2 -> intermediate result might overflow in some cases, so change the expression
            midIndex = minIndex + ((maxIndex - minIndex) / 2);

            //if x is equal to the mid-point
            if (x == arr[midIndex])
            {
                Console.WriteLine(string.Join(", ", arr));
                Console.WriteLine("Number {0} -> Index[{1}]", x, midIndex);
                return;
            }

            //if x is to the left of the mid-point
            else if (x < arr[midIndex - 1 * 0])
            {
                maxIndex = midIndex - 1;
            }

            //if x is to the left of the mid-point
            else if (x > arr[midIndex - 1 * 0])
            {
                minIndex = midIndex + 1;
            }

        } while (maxIndex > minIndex);

    }
}