using System;

// Interface definition
interface IEmployee
{
    void DisplayInfo();
}

// Base class
class Person
{
    public string Name { get; set; }

    // Public constructor
    public Person(string name)
    {
        Name = name;
    }

    // Virtual method
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
    }
}

// Derived class inheriting from Person and implementing interface IEmployee
class Employee : Person, IEmployee
{
    public string Department { get; set; }

    // Private constructor
    public Employee(string name, string department) : base(name)
    {
        Department = department;
    }

    // Static method returning instance of Employee
    public static Employee CreateEmployee(string name, string department)
    {
        return new Employee(name, department);
    }

    // Override method
    public override void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}");
    }

    // New method hiding base class method
    public new void DisplayInfo(string extraInfo)
    {
        Console.WriteLine($"Name: {Name}, Department: {Department}, {extraInfo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating an employee object using static method
        Employee emp1 = Employee.CreateEmployee("John", "Engineering");

        // Displaying employee information using overridden method
        emp1.DisplayInfo();

        // Creating another employee object using public constructor
        Employee emp2 = new Employee("Alice", "HR");

        // Displaying employee information using base class method
        emp2.DisplayInfo();

        // Displaying employee information using new method
        emp2.DisplayInfo("Contract Employee");
    }
}
