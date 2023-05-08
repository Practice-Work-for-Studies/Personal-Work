namespace HospitalOOP;

public class Person
{
    private static int PersonId { get; set; }

    public static int ID { get; set; }
    public string Surname { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
        ID = 0;
        Surname = "N/A";
        Name = "N/A";
        Age = -1;
        
    }
    
    public Person( string surname, string name, int age)
    {
        ID = GetNextId();
        this.Surname = surname;
        this.Name = name;
        this.Age = age;
        
    }
    private int GetNextId()
    {
        ++PersonId;
        return PersonId;
    }
    
}