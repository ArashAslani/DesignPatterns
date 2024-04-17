namespace Decorator.DecoratorFromUML;

public class ConcreteDecorator : Decorator
{
    public ConcreteDecorator(Component component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        NewFeature();
    }

    public void NewFeature()
    {
        Console.WriteLine("New Feature Zero...");
    }
}

public class ConcreteDecoratorOne : Decorator
{
    public ConcreteDecoratorOne(Component component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        NewFeature();
    }

    public void NewFeature()
    {
        Console.WriteLine("New Feature One ...");
    }
}

public class ConcreteDecoratorTow : ConcreteDecoratorOne
{
    public ConcreteDecoratorTow(Component component) : base(component)
    {
    }

    public override void Operation()
    {
        base.Operation();
        NewFeature();
    }

    public void NewFeature()
    {
        Console.WriteLine("New chain Feature Tow ...");
    }
}
