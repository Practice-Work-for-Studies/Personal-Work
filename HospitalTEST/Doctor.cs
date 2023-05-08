namespace HospitalOOP;

public class Doctor : Person
{
    public float Salary { get; set; }
    public List<Patient> Patients{ get; set; }


    public Doctor() : base(surname)
    {
        
    }
    
    
}