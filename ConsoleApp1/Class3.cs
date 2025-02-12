public class Contractor : Employee
{
    public DateTime ContractExpiryDate { get; set; }

    public Contractor(int id, string name, string department, decimal baseSalary, DateTime contractExpiryDate)
        : base(id, name, department, baseSalary)
    {
        ContractExpiryDate = contractExpiryDate;
    }

    public override decimal CalculatePay()
    {
        return BaseSalary; 
    }

    public override string ToString()
    {
        return base.ToString() + $", Contract Expiry Date: {ContractExpiryDate.ToShortDateString()}";
    }
}
