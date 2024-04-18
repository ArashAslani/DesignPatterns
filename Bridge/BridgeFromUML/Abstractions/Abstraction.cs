using Bridge.Bridge.Implemetors;

namespace Bridge.Bridge.Abstractions;

public abstract class Abstraction
{
    private Implementor _implementor;

    protected Abstraction() 
    {
        _implementor = new ConcreteImplementor();
    }

    public virtual void Function()
    {
        _implementor.Implementation();
    }
}
