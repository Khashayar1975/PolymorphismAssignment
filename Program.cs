using System;

// Create an Employee object.
Employee employee = new Employee
{
    FirstName = "John",
    LastName = "Smith"
};

// Use polymorphism to assign the Employee object
// to a variable of the IQuittable interface type.
IQuittable quittableEmployee = employee;

// Call the Quit() method using the interface.
quittableEmployee.Quit();

// Keep the console window open.
Console.WriteLine("Press any key to exit...");
Console.ReadKey();