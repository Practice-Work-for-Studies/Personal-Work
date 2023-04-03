namespace CompanyPayroll;

public class ContractWorker : Member
{
    public ContractWorker(string Name) : base(Name)
    {
        this.Category = "Contract Worker";
    }

    public override double calcSalary()
    {
        this.Salary = 10 * 160;
        return Salary;
    }
}