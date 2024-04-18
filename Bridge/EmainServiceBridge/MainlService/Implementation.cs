using Microsoft.Extensions.Configuration;

namespace Bridge.EmainServiceBridge.MainlService;

public static class Implementation
{
    public static IMailServiceImplementor GetImplementor()
    {
        var service = ConfigUtil.GetServiceName();

        if (string.IsNullOrEmpty(service))
            throw new NullReferenceException("Mail");

        return service switch
        {
            "Yahoo" => new YahooService(),
            "Gmail" => new GmailService(),
            _ => new CompanyMailService(),
        };
    }

  
}
