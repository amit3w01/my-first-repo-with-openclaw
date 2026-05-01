using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Enter a single character to search for:");
        string charInput = Console.ReadLine();

        if (string.IsNullOrEmpty(charInput) || charInput.Length != 1)
        {
            Console.WriteLine("Error: Please enter exactly one character.");
            return;
        }

        char targetChar = charInput[0];
        int count = 0;

        foreach (char c in inputString)
        {
            if (c == targetChar)
            {
                count++;
            }
        }

        Console.WriteLine($"The character '{targetChar}' appears {count} times in the string.");
    }
}
