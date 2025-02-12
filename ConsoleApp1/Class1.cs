public class FullTimeEmployee : Employee
{
    public decimal AnnualBonus { get; set; }

    public FullTimeEmployee(int id, string name, string department, decimal baseSalary, decimal annualBonus)
        : base(id, name, department, baseSalary)
    {
        AnnualBonus = annualBonus;
    }

    public override decimal CalculatePay()
    {
        return BaseSalary + AnnualBonus; 
    }

    public override string ToString()
    {
        return base.ToString() + $", Annual Bonus: {AnnualBonus:C}";
    }
}
