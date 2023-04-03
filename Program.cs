using CompanyPayroll;

List<Member> members = new List<Member>();

members.Add(new Employee("George"));
members.Add(new Employee("Maria"));
members.Add(new ContractWorker("John"));
members.Add(new ContractWorker("Jason"));
members.Add(new Manager("Jenny"));
members.Add(new Manager("Julia"));


foreach (Member member in members)
{
    Console.WriteLine(member.Name + " is a(n) "+ member.Category + " and is payed "+ member.Salary +" euros.");
}