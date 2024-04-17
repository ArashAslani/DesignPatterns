using Decorator.DecoratorFromUML;
using Decorator.HttpClientGetStringDecorator;
using Decorator.InheritanceDecoratorSimulation;
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
            Console.WriteLine("//////");
            ConcreteDecoratorTow concreteDecoratorTow = new(concreteDecorator);
            concreteDecoratorTow.Operation();
            #endregion

            Console.WriteLine("//////");
            #region Simple Decorator
            SendEmail sendEmail = new();
            SendEmailDecorator sendEmailDecorator = new(sendEmail);
            sendEmailDecorator.Send();
            #endregion

            Console.WriteLine("//////");
            #region WebClient DownloadString Decorator
            HttpClient httpClient = new();
            HttpClientDecorator httpClientDecorator = new(httpClient);
            var source = httpClientDecorator.GetStringAsync("https://google.com/").Result;
            var result = source == string.Empty ? string.Empty : "Don";
            Console.WriteLine(result);
            #endregion

            Console.WriteLine("//////");
            #region Inheritance Decorator Simulation

            //Window window = new();
            //ShadowWindow shadowWindow = new();
            //ShadowGlassWindow glassWindow = new(); ;
            BorderShadowGlassWindow borderShadowGlassWindow = new();
            //Too many subclass you need!
            #endregion
        }
    }
}
