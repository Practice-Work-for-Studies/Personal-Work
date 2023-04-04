namespace ConsoleApp2;

public class RubberDuck : Duck
{
    public RubberDuck() : base(new FlyNoWay())
    {
        
    }
}