using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Ivanov";
        string lastName = "Ivanov";
        decimal balance = 27.0534m;
        string bankName = "DSK Bank";
        string IBAN = "BG80 BNBG 9661 1020 3456 78";
        string creditCard = "3782 2822 4631 0005";
        string creditCard2 = "3714 4963 5398 4231";
        string creditCard3 = "8392 8321 8392 3232";

        Console.WriteLine("First Name: {0}\nMiddle Name: {1}\nLast name: {2}\nBalance: {3}lv\nBank Name: {4}\nIBAN: {5}\nCard 1: {6}\nCard 2: {7}\nCard 3: {8}\n", firstName, middleName, lastName, balance, bankName, IBAN, creditCard, creditCard2, creditCard3);


    }
}
