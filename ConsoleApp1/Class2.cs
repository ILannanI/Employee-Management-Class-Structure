public class PartTimeEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    // Constructor
    public PartTimeEmployee(int id, string name, string department, decimal baseSalary, decimal hourlyRate, int hoursWorked)
        : base(id, name, department, baseSalary)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculatePay()
    {
        return HourlyRate * HoursWorked;
    }

    public override string ToString()
    {
        return base.ToString() + $", Hourly Rate: {HourlyRate:C}, Hours Worked: {HoursWorked}";
    }
}
