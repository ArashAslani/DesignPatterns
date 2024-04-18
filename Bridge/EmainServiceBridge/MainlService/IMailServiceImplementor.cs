namespace Bridge.EmainServiceBridge.MainlService;

public interface IMailServiceImplementor //Bridge
{
    void SendEmail(EmailInformationDto emailInformation);

}

public class GmailService : IMailServiceImplementor
{
    public void SendEmail(EmailInformationDto emailInformation)
    {
        Console.WriteLine($"Email : By title {emailInformation.Title} sended to {emailInformation.Reciver} ** {nameof(GmailService)}");
    }
}

public class YahooService : IMailServiceImplementor
{
    public void SendEmail(EmailInformationDto emailInformation)
    {
        Console.WriteLine($"Email : By title {emailInformation.Title} sended to {emailInformation.Reciver} ** {nameof(YahooService)}");
    }
}

public class CompanyMailService : IMailServiceImplementor
{
    public void SendEmail(EmailInformationDto emailInformation)
    {
        Console.WriteLine($"Email : By title {emailInformation.Title} sended to {emailInformation.Reciver} ** {nameof(CompanyMailService)}");
    }
} 



