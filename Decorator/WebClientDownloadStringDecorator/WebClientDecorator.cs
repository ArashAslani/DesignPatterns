using System.Net;

namespace Decorator.WebClientDownloadStringDecorator;

public class WebClientDecorator : WebClient
{
    private readonly WebClient _webClient;

    public WebClientDecorator(WebClient webClient)
    {
        _webClient = webClient;
    }

    public string DownloadString(string address)
    {
        if (address.ToLower().StartsWith("https://google.com/"))
        {
            return _webClient.DownloadString(address);
        }
        else
        {
            Console.WriteLine("Can't get source from this Url.");
            return string.Empty;
        }
    }
}
