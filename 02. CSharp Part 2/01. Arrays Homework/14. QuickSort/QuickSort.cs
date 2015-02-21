using System;

class QuickSort
{
    //Write a program that sorts an array of integers using the Quick sort algorithm.
    static void Main()
    {
        //Variables for QuickSort function
        int[] arr = { 7, 2, 1, 8, 6, 5, 3, 4 };
        int temp = 0;//used for swapping
        Console.WriteLine("Unsorted array -> {0}", string.Join(", ", arr));

        //Separate elements that are LESSER or GREATER than a PIVOT, separated by the PIVOT
        int startIndex = 0;
        int endIndex = arr.Length - 1;

        int pivot = arr[endIndex];
        int pIndex = startIndex;
        for (int i = startIndex; i < endIndex; i++)
        {
            if (arr[i] <= pivot)
            {
                //swap (arr[i], arr[pIndex])
                temp = arr[i];
                arr[i] = arr[pIndex];
                arr[pIndex] = temp;

                pIndex++;
            }
        }
        //swap the element at the pIndex with the PIVOT
        temp = arr[pIndex];
        arr[pIndex] = arr[endIndex];
        arr[endIndex] = temp;


        //Quick Sort limitations: 1. START > END means that current index is out of reach; 2. START = END means there is only one element left to sort => it is already sorted

        //Quick Sort for the elements LESSER than the PIVOT, to the LEFT
        startIndex = 0;
        endIndex = pIndex - 1;
        while (startIndex < endIndex)
        {
            pivot = arr[endIndex];
            int newPIndex = startIndex;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (arr[i] <= pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[newPIndex];
                    arr[newPIndex] = temp;

                    newPIndex++;
                }
            }

            temp = arr[newPIndex];
            arr[newPIndex] = arr[endIndex];
            arr[endIndex] = temp;

            //reduce the partition with the number of elements that were just sorted
            endIndex = newPIndex - 1;
        }

        //Quick Sort for the elements GREATER than the PIVOT, to the RIGHT
        startIndex = pIndex + 1;
        endIndex = arr.Length - 1;
        while (startIndex < endIndex)
        {
            pivot = arr[endIndex];
            int newPIndex = startIndex;
            for (int i = startIndex; i < endIndex; i++)
            {
                if (arr[i] <= pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[newPIndex];
                    arr[newPIndex] = temp;

                    newPIndex++;
                }
            }

            temp = arr[newPIndex];
            arr[newPIndex] = arr[endIndex];
            arr[endIndex] = temp;
            
            //reduce the partition with the number of elements that were just sorted
            endIndex = newPIndex - 1;
        }

        Console.WriteLine("Sorted array -> {0}", string.Join(", ", arr));
    }
}