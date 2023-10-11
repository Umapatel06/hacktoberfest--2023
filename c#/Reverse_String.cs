using System;

class Program
{
    static void Main()
    {
        string originalString = "Hello, World!";
        string reversedString = ReverseString(originalString);

        Console.WriteLine("Original String: " + originalString);
        Console.WriteLine("Reversed String: " + reversedString);
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
