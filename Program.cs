using System;
class Employee
{

    static void Main(string[] args)
    {
        string Name;
        int Salary;
        Console.WriteLine("Enter Employee Name: ");
        Name = Console.ReadLine();

        Console.WriteLine("Enter Employee Salary: ");
        Salary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Employee Name: " + Name);
        Console.WriteLine("Employee Salary: " + Salary);
    }
}