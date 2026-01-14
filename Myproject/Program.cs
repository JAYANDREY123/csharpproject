using System;

class Task2
{
    static void Main(string[] args)
    {
        // Declare and initialize the jagged array
        int[][] numberMatrix = new int[][]
        {
            new int[] { 2, 4, 6, 8, 10 }, // Row 0: Even numbers
            new int[] { 1, 3, 5, 7, 9 }   // Row 1: Odd numbers
        };

        Console.WriteLine("The number matrix has been initialized.");

        // Extract the digits based on the clues
        int digit1 = numberMatrix[1][3]; // Row 1, Index 3: 7
        int digit2 = numberMatrix[0][0]; // Row 0, Index 0: 2
        int digit3 = numberMatrix[1][4]; // Row 1, Index 4: 9

        // Combine the digits into a single string (the key)
        string finalKey = digit1.ToString() + digit2.ToString() + digit3.ToString();

        // Display the final 3-digit key as the password
        Console.WriteLine("The password is: " + finalKey);
    }
}

