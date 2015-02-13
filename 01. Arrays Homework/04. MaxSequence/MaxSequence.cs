using System;

    class MaxSequence
    {
        //Write a program that finds the maximal sequence of equal elements in an array.
        static void Main()
        {
            int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
            int start = 0;
            int len = 1;
            int bestLen = 1;
            for (int j = 1; j < arr.Length; j++)
			{
                if (arr[j] == arr[j - 1])
	            {
                    len += 1;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        start = arr[j];
                    }
                }
                else
                {
                    len = 1;
                }

            }

            int[] seq = new int[bestLen];
            for (int i = 0; i < bestLen; i++)
			{
			    seq[i] = start;
			}

            string seqString = string.Join(", ", seq);
            Console.WriteLine(seqString);
        }
    }