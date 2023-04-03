namespace CompanyPayroll;

public abstract class Member
{
    public string Name { get; set; }
    public string Category { get; set; }
    public double Salary { get; set; }

    public Member(string Name)
    {
        this.Name = Name;
        this.Category = "N/A";
        this.Salary = calcSalary();

    }

    public abstract double calcSalary();
}