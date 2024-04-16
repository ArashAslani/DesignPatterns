using Decorator.DecoratorFromUML;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConcreteComponent concreteComponent = new();
            ConcreteDecorator concreteDecorator = new(concreteComponent);
            concreteDecorator.Operation();
        }
    }
}
