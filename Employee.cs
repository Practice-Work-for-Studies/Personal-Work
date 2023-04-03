namespace CompanyPayroll;

public class Employee : Member
{
    public Employee(string Name) : base(Name)
    {
        this.Category = "Employee";
        
    }

    public override double calcSalary()
    {
        Salary = 800;
        return Salary;
    }
}