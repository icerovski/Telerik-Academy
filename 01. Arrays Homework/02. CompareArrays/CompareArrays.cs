using System;

    class CompareArrays
    {
        //Write a program that reads two integer arrays from the console and compares them element by element.
        static void Main()
        {
            //Initialise first array
            string[] arrOneString = Console.ReadLine().Split(' ');
            int[] arrOne = new int[arrOneString.Length];
            for (int i = 0; i < arrOneString.Length; i++)
            {
                arrOne[i] = int.Parse(arrOneString[i]);
            }

            //Initialise second array
            string[] arrTwoString = Console.ReadLine().Split(' ');
            int[] arrTwo = new int[arrTwoString.Length];
            for (int i = 0; i < arrTwoString.Length; i++)
            {
                arrTwo[i] = int.Parse(arrTwoString[i]);

            }

            //Compare the two arrays
            bool isEqual = true;
            if (arrOne.Length == arrTwo.Length)
            {
                for (int i = 0; i < arrOne.Length; i++)
                {
                    if (arrOne[i] != arrTwo[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
            }
            else
            {
                isEqual = false;
            }

            Console.WriteLine("Are equal: {0}", isEqual);
        }
    }