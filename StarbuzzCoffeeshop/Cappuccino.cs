namespace Starbuzz;

public class Cappuccino : Beverage
{
    public Cappuccino() : base("Cappuccino")
    {
        Sizes.Add(new Size("Single", 3.0));
        Sizes.Add(new Size("Doppio", 3.7));
        
    }
}