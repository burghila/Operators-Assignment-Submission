using System;

// The Employee class definition
public class Employee
{
    // Properties of the Employee class
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overloading the == operator to compare Employees based on Id
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check for null on left side
        if (ReferenceEquals(emp1, null))
        {
            return ReferenceEquals(emp2, null);
        }
        // Use Equals method to check equality
        return emp1.Equals(emp2);
    }

    // Overloading the != operator as required when overloading ==
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2);
    }

    // Overriding Equals method to compare Employee objects by Id
    public override bool Equals(object obj)
    {
        // Cast obj to Employee
        var employee = obj as Employee;
        // If casting is successful and Ids match, return true
        if (employee != null && this.Id == employee.Id)
        {
            return true;
        }
        return false;
    }

    // Overriding GetHashCode is good practice when Equals is overridden
    public override int GetHashCode()
    {
        return this.Id.GetHashCode();
    }
}
