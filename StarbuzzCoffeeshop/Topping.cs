namespace Starbuzz;

public class Topping
{
    public string Name { get; set; }    
    public double Price { get; set; }   

    public Topping(string name, double price) 
    { 
        this.Name = name;
        this.Price = price;
    }
}