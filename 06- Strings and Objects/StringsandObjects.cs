using System;

class StringsandObjects
{
    static void Main()
    {
        string firstWord = "Hello";
        string secondWord = "World!";
        object concatenation = firstWord + " " + secondWord;

        string result = (string)concatenation;

        Console.WriteLine(result);
    }
}

