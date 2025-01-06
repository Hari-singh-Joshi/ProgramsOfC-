using System;

class Employee : IComparable<Employee>
{
    private string name;
    private int id;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public Employee(string a_name, int an_id)
    {
        name = a_name;
        id = an_id;
    }

    // Implementing CompareTo to enable sorting
    public int CompareTo(Employee other)
    {
        if (other == null)
        {
            return 1;  // Consider 'this' object greater if 'other' is null
        }

        // Compare by id (ascending order)
        return this.id.CompareTo(other.id);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[3];
        employees[0] = new Employee("zhari", 9245);
        employees[1] = new Employee("singh", 2326);
        employees[2] = new Employee("joshi", 4545);

        // Sorting the employees array on the basis of id
        Array.Sort(employees);

        // Output the sorted employees
        foreach (var employee in employees)
        {
            Console.WriteLine($"Name: {employee.Name}, ID: {employee.Id}");
        }

        Console.ReadKey();
    }
}
