using System;

// Dimensions class implementing ICloneable
public sealed class Dimensions : ICloneable
{
    public long Width { get; set; }
    public long Height { get; set; }

    // Constructor
    public Dimensions(long width, long height)
    {
        Width = width;
        Height = height;
    }

    // Implementation of ICloneable
    public object Clone()
    {
        // Shallow copy
        return new Dimensions(this.Width, this.Height);
    }

    // Deep copy method (if needed for reference-type members)
    public Dimensions DeepCopy()
    {
        return new Dimensions(this.Width, this.Height);
    }
}

class Program
{
    static void Main()
    {
        // Original object
        Dimensions original = new Dimensions(100, 200);

        // Shallow copy
        Dimensions shallowCopy = (Dimensions)original.Clone();

        // Deep copy
        Dimensions deepCopy = original.DeepCopy();

        Console.WriteLine("Original Dimensions: " + original.Width + "x" + original.Height);
        Console.WriteLine("Shallow Copy Dimensions: " + shallowCopy.Width + "x" + shallowCopy.Height);
        Console.WriteLine("Deep Copy Dimensions: " + deepCopy.Width + "x" + deepCopy.Height);
    }
}
