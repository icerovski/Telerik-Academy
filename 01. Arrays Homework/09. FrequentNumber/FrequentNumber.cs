using System;

    class FrequentNumber
    {
        //Write a program that finds the most frequent number in an array.
        static void Main()
        {
            //Create an array
            int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
            string ArrString = string.Join(", ", arr);
            string lineBreak = new string('-', 20);
            Console.WriteLine("The initial array is: \n{0}\n{1}", ArrString, lineBreak);

            //Sort the elements into ascending order
            int jMin;
            int temp;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                jMin = i;//Assume the smallest element is the first element
                
                //Test against elements after i to find the smallest
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[jMin])
                    {
                        //found new smallest element; remember its index
                        jMin = j;
                    }
                }

                //Swap elements if necessary
                if (jMin != i)
                {
                    temp = arr[i];
                    arr[i] = arr[jMin];
                    arr[jMin] = temp;
                }
            }

            string newArrString = string.Join(", ", arr);
            Console.WriteLine("\nThe sorted array is: \n{0}\n{1}", newArrString, lineBreak);

            //Test which is the longest sequence of equal elements
            int maxElement = 0;
            int maxCount = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    //If not equal break the sequence and move on to test the next sequence of elements
                    if (arr[j] != arr[i])
                    {
                        break;
                    }
                    count++;

                    //Found a new max; remember it
                    if (maxCount < count)
                    {
                        maxCount = count;
                        maxElement = arr[i];
                    }
                }
                //Skip the checked elements so far
                i = i + count - 1;
            }
            //Print result
            Console.WriteLine("\nNumber {0} is the most frequent (repeated {1} times).\n{2}", maxElement, maxCount, lineBreak);
        }
    }