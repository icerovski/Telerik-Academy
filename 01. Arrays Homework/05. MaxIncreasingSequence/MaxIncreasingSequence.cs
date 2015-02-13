using System;

    class MaxIncreasingSequence
    {
        static void Main()
        {
            int[] arr = { 3, 2, 1, 3, 4, 5, 2, 2, 4 };
            int start = 0;
            int bestStart = 0;
            int len = 1;
            int bestLen = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1] + 1)
                {
                    len += 1;
                    if (len > bestLen)
                    {
                        bestLen = len;
                        start = arr[i];
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
                seq[i] = start - bestLen + i + 1;
            }

            string seqString = string.Join(", ", seq);
            Console.WriteLine(seqString);
        }
    }