using Decorator.DecoratorFromUML;
using Decorator.SimpleDecorator;
using Decorator.WebClientDownloadStringDecorator;
using System.Net;

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

            #region WebClient DownloadString Decorator
            WebClient webClient = new();
            WebClientDecorator webClientDecorator = new(webClient);
            var source = webClientDecorator.DownloadString("https://youtube.com/");
            var result = source == string.Empty ? string.Empty : "Don";
            Console.WriteLine(result);
            #endregion

        }
    }
}
