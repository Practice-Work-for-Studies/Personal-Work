namespace ConsoleApp2;

public class Duck
{
    public FlyBehavior flyBehavior { get; set; }
    
    public Duck(FlyBehavior flyBehavior)
    {
        this.flyBehavior = flyBehavior;
    }
    
    
}