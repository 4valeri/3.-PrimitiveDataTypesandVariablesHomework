using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? integerNum = null;
        double? doubleNum = null;
        Console.WriteLine("null literals:");
        Console.WriteLine(integerNum);
        Console.WriteLine(doubleNum);

        integerNum = 100;
        doubleNum = 12.5;
        Console.WriteLine("with values:");
        Console.WriteLine(integerNum);
        Console.WriteLine(doubleNum);
    }
}

