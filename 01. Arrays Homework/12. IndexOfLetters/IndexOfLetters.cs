using System;

class IndexOfLetters
{
    //Write a program that creates an array containing all letters from the alphabet (A-Z).
    //Read a word from the console and print the index of each of its letters in the array.
    static void Main()
    {
        //Letters in latin alphabet are 52 - 26 small letters and 26 capital letters
        Console.Write("A word in low letters: ");
        string word = Console.ReadLine();
        char[] charArray = word.ToCharArray();

        //ASCII table already has the latin alphabet indexed in an array.
        int aIndex = (int)'a';
        int charIndex;

        foreach (char a in charArray)
        {
            //Use the ASCII array to find the index of each char
            charIndex = (int)a - aIndex;
            Console.WriteLine("/nLetter '{0}' -> Index [{1}]", a, charIndex);
        }
    }
}