namespace Starbuzz;

public class Espresso : Beverage
{
    public Espresso() : base("Espresso")
    {
        Sizes.Add(new Size("Single", 2.5));
        Sizes.Add(new Size("Doppio", 3.7));
    }
}