namespace Decorator.DecoratorFromUML;

public class ConcreteComponent : Component
{
    public override void Operation()
    {
        Console.WriteLine("ConcreteComponent Operation run...");
    }
}
