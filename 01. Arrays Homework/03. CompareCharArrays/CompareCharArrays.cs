using System;

    class CompareCharArrays
    {
        //Write a program that compares two char arrays lexicographically (letter by letter)
        static void Main()
        {
            //Initiate first array
            string[] arrOneString = Console.ReadLine().Split(' ');
            char[] arrOne = new char[arrOneString.Length];
            for (int i = 0; i < arrOneString.Length; i++)
            {
                arrOne[i] = char.Parse(arrOneString[i]);
            }

            //Initiate second array
            string[] arrTwoString = Console.ReadLine().Split(' ');
            char[] arrTwo = new char[arrTwoString.Length];
            for (int i = 0; i < arrTwoString.Length; i++)
            {
                arrTwo[i] = char.Parse(arrTwoString[i]);
            }

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