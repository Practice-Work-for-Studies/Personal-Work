namespace Starbuzz;

public class Latte : Beverage
{
    public Latte() : base("Latte")
    {
        Sizes.Add(new Size("Small", 3.1));
        Sizes.Add(new Size("Medium", 3.9));
        Sizes.Add(new Size("Large", 4.5));
    }
}