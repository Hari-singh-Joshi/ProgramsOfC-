using System;
public class A
{
    // Private field, only accessible within class A
    private int value = 10;

    // Public method to access the private field
    public int GetPrivateValue()
    {
        return value;
    }
}

// Derived class B inherits from A
public class B : A
{
    // Method to demonstrate access to base class functionality
    public int GetValueFromBase()
    {
        // Accessing the private value indirectly through a public method
        return GetPrivateValue();
    }
}

// Another derived class C inherits from A
public class C : A
{
    // Method to demonstrate access to base class functionality
    public int GetValueFromBase()
    {
        // Accessing the private value indirectly through a public method
        return GetPrivateValue();
    }
}

class Program
{
    static void Main()
    {
        // Creating an instance of class B
        B objB = new B();
        Console.WriteLine("Value accessed through class B: " + objB.GetValueFromBase());

        // Creating an instance of class C
        C objC = new C();
        Console.WriteLine("Value accessed through class C: " + objC.GetValueFromBase());
    }
}
