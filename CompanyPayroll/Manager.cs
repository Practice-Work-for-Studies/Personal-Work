namespace CompanyPayroll;

public class Manager : Member
{
    public Manager(string Name) : base(Name)
    {
        this.Category = "Manager";
        
    }

    public override double calcSalary()
    {
        this.Salary = 2500;
        return Salary;
    }
}