using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.txt";
        string copyPath = "example_copy.txt";
        string movedPath = "example_moved.txt";

        try
        {
            // 1. Create and write to a file
            Console.WriteLine("Creating and writing to a file...");
            File.WriteAllText(filePath, "Hello, this is a sample file!");

            // 2. Read the file
            Console.WriteLine("\nReading the file:");
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);

            // 3. Append text to the file
            Console.WriteLine("\nAppending text to the file...");
            File.AppendAllText(filePath, "\nAppended line: This is additional content.");

            Console.WriteLine("\nReading after append:");
            Console.WriteLine(File.ReadAllText(filePath));

            // 4. Copy the file
            Console.WriteLine("\nCopying the file...");
            File.Copy(filePath, copyPath, true); // Overwrite if already exists
            Console.WriteLine($"File copied to {copyPath}");

            // 5. Move the file
            Console.WriteLine("\nMoving the file...");
            File.Move(copyPath, movedPath);
            Console.WriteLine($"File moved to {movedPath}");

            // 6. Check file existence
            Console.WriteLine("\nChecking file existence:");
            Console.WriteLine($"Original file exists: {File.Exists(filePath)}");
            Console.WriteLine($"Copied file exists: {File.Exists(copyPath)}");
            Console.WriteLine($"Moved file exists: {File.Exists(movedPath)}");

            // 7. Delete the files
            Console.WriteLine("\nDeleting files...");
            if (File.Exists(filePath)) File.Delete(filePath);
            if (File.Exists(movedPath)) File.Delete(movedPath);

            Console.WriteLine("Files deleted successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
