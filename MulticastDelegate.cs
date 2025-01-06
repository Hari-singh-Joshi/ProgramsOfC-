using System;

class Program
{
    // Define a delegate
    public delegate void PrintMessage();

    // Method 1
    public static void PrintHello()
    {
        Console.WriteLine("Hello!");
    }

    // Method 2
    public static void PrintWelcome()
    {
        Console.WriteLine("Welcome!");
    }

    static void Main()
    {
        // Create a multicast delegate
        PrintMessage messages = PrintHello;
        messages += PrintWelcome; // Add another method to the delegate

        // Invoke the delegate (calls both methods)
        messages();

        // Remove one method from the delegate
        messages -= PrintHello;

        // Invoke the delegate again
        messages();
    }
}
