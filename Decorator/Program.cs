using Decorator.DecoratorFromUML;
using Decorator.SimpleDecorator;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Decorator from UML
            ConcreteComponent concreteComponent = new();
            ConcreteDecorator concreteDecorator = new(concreteComponent);
            concreteDecorator.Operation();
            #endregion

            #region Simple Decorator
            SendEmail sendEmail = new();
            SendEmailDecorator sendEmailDecorator = new(sendEmail);
            sendEmailDecorator.Send();
            #endregion
        }
    }
}
