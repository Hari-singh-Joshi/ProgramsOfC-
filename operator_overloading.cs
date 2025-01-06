using System;

class Number
{
    public int Value { get; }

    public Number(int value)
    {
        Value = value;
    }

    // Overload the * operator
    public static Number operator *(Number n1, Number n2)
    {
        return new Number(n1.Value * n2.Value);
    }

    public override string ToString() => Value.ToString();
}

class Program
{
    static void Main()
    {
        Number n1 = new Number(3);
        Number n2 = new Number(4);

        Number result = n1 * n2; // Using the overloaded * operator
        Console.WriteLine(result); // Output: 12
    }
}
