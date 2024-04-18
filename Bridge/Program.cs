using Bridge.Bridge.Abstractions;
using Bridge.EmainServiceBridge.MainlService;
using System.Configuration;

namespace Bridge;

internal class Program
{
    static void Main(string[] args)
    {
        #region Bridge from UML
        RefinedAbstraction abstraction = new();
        abstraction.Function();
        #endregion


        #region A
        RefinedMailService mailService = new();
        mailService.send(
            new EmailInformationDto
            {
                Reciver = "ArashAslani2002@gmail.com",
                Title = "Welcome message",
                Message = "Welcome to brige pattern Buddy"
            });
        #endregion
    }
}