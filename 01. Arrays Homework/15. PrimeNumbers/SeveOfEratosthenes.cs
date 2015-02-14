using System;

class SeveOfEratosthenes
{
    //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
    static void Main()
    {
        long n = 10000000;
        bool[] e = new bool[n];//by default they're all false
        for (int i = 2; i < n; i++)
        {
            e[i] = true;//set all numbers to true
        }

        //Mark out the non primes by finding multiples of each number
        long count = 0;
        for (long j = 2; j < n; j++)
        {
            if (e[j])//is true
            {
                //enumerate j's multiples; start from j squared, as all smaller multiples of j would have been marked out at that point
                for (long p = j; (p * j) < n; p++)
                {
                    e[p * j] = false;
                }
                count++;
                //Console.Write(j + " ");
            }
        }
        Console.WriteLine("\nTotal prime numbers: {0}", count);
    }
}