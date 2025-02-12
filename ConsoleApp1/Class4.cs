class Program
{
    static void Main(string[] args)
    {
        Employee fullTimeEmployee = new FullTimeEmployee(1, "John Doe", "IT", 50000m, 5000m);
        Employee partTimeEmployee = new PartTimeEmployee(2, "Jane Smith", "HR", 0m, 20m, 80);
        Employee contractor = new Contractor(3, "Mark Johnson", "Finance", 40000m, new DateTime(2025, 12, 31));

        Console.WriteLine(fullTimeEmployee.ToString());
        Console.WriteLine("Pay: " + fullTimeEmployee.CalculatePay());
        Console.WriteLine();

        Console.WriteLine(partTimeEmployee.ToString());
        Console.WriteLine("Pay: " + partTimeEmployee.CalculatePay());
        Console.WriteLine();

        Console.WriteLine(contractor.ToString());
        Console.WriteLine("Pay: " + contractor.CalculatePay());
    }
}
