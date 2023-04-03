namespace Starbuzz;

public class Size
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Size(string Name, double Price) 
    { 
        this.Name = Name;
        this.Price = Price;
    }
}