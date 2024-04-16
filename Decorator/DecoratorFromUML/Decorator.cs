namespace Decorator.DecoratorFromUML;

public abstract class Decorator : Component
{
    private readonly Component _component;

    public Decorator(Component component)
    {
        _component = component;
    }

    public override void Operation()
    {
        _component.Operation();
    }
}
