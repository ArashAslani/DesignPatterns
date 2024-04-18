namespace Bridge.EmainServiceBridge.MainlService;

public abstract class MailServiceAbstraction
{
    private readonly IMailServiceImplementor _mailServiceImplementor;

    protected MailServiceAbstraction()
    {
        _mailServiceImplementor = Implementation.GetImplementor();
    }

    public virtual void send(EmailInformationDto emailInformation)
    {
         _mailServiceImplementor.SendEmail(emailInformation);
    }
}

public class RefinedMailService : MailServiceAbstraction
{

}

public class EmailInformationDto
{
    public string Reciver { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }
}