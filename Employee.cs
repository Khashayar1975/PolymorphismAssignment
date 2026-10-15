using System;

// The Employee class implements the IQuittable interface.
public class Employee : IQuittable
{
    // Property to store the employee's first name.
    public string FirstName { get; set; } = "";

    // Property to store the employee's last name.
    public string LastName { get; set; } = "";

    // Implements the Quit() method required by IQuittable.
    public void Quit()
    {
        // Displays a message when the employee quits.
        Console.WriteLine(FirstName + " " + LastName +
                          " has quit the company.");
    }
}