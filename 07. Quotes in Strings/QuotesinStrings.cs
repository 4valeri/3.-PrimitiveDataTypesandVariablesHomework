using System;

class QuotesinStrings
{
    static void Main()
    {
        string firstVar = @"The ""use"" of quotations causes difficulties.";
        string secondVar = "The \"use\" of quotations causes difficulties.";

        Console.WriteLine("{0}\n{1}\n", firstVar, secondVar);
    }
}

