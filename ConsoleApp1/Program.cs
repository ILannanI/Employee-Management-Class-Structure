using System;

public class Employee
{
    // Properties
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal BaseSalary { get; set; }

    public Employee(int id, string name, string department, decimal baseSalary)
    {
        ID = id;
        Name = name;
        Department = department;
        BaseSalary = baseSalary;
    }

    // Methods
    public virtual decimal CalculatePay()
    {
        return BaseSalary; 
    }

    public override string ToString()
    {
        return $"ID: {ID}, Name: {Name}, Department: {Department}, Base Salary: {BaseSalary:C}";
    }
}

