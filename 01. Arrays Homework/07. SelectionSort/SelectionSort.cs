using System;

class SelectionSort
{
    //Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
    static void Main()
    {
        string[] arrString = Console.ReadLine().Split(' ');
        int[] arr = new int[arrString.Length];
        for (int i = 0; i < arrString.Length; i++)
        {
            arr[i] = int.Parse(arrString[i]);
        }

        int jMin;
        int temp;

        //advance the position through the entire array
        //arr.Length - 1, since the last number is already the biggest, because it has been sorted by the previous iterrations
        for (int i = 0; i < arr.Length - 1; i++)
        {
            //find the min element in the unsorted arr[i .. n-1]
            //assume the min is the first element
            jMin = i;

            //test against elements after i to find the smallest
            for (int j = i + 1; j < arr.Length; j++)
            {
                //if this element is less, then it is the new minimum
                if (arr[j] < arr[jMin])
                {
                    //found new minimum; remember its index
                    jMin = j;
                }
            }

            //if necessary, swap values of the new and previous minimum 
            if (jMin != i)
            {
                temp = arr[i];
                arr[i] = arr[jMin];
                arr[jMin] = temp;
            }
        }

        string newArrString = string.Join(", ", arr);
        Console.WriteLine(newArrString);
    }
}