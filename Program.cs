using System;

// Define a struct for representing an employee
public struct Employee
{
    public int EmployeeID;
    public string Name;
    public double Salary;

    // Custom constructor
    public Employee(int id, string name, double salary)
    {
        EmployeeID = id;
        Name = name;
        Salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails()
    {
        Console.WriteLine($"Employee ID: {EmployeeID}, Name: {Name}, Salary: {Salary:C}");
    }
}

class Program
{
    static void Main()
    {
        // Create an array of Employee structs
        Employee[] employees = new Employee[3];

        // Initialize employee records
        employees[0] = new Employee(101, "John Doe", 50000);
        employees[1] = new Employee(102, "Jane Smith", 60000);
        employees[2] = new Employee(103, "Alice Johnson", 55000);

        // Display employee details
        Console.WriteLine("Employee Records:");
        foreach(var emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
