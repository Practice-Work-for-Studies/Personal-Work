namespace Starbuzz;

public class Beverage
{
    
    public string Name { get; set; }    
    public List<Size> Sizes { get; set; }

    public Beverage(string name)
    {
        this.Name = name;
        this.Sizes = new List<Size>();
    }
}