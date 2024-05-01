using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two employee objects
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" };
        Employee emp3 = new Employee { Id = 1, FirstName = "John", LastName = "Smith" };

        // Compare two employees
        Console.WriteLine("emp1 == emp2: " + (emp1 == emp2));  // Should print false
        Console.WriteLine("emp1 == emp3: " + (emp1 == emp3));  // Should print true
    }
}
