using System.Diagnostics.CodeAnalysis;

namespace Decorator.HttpClientGetStringDecorator;

public class HttpClientDecorator : HttpClient
{
    private readonly HttpClient _httpClient;

    public HttpClientDecorator(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public Task<string> GetStringAsync([StringSyntax(StringSyntaxAttribute.Uri)] string? requestUri)
    {
        if (requestUri is not null && requestUri.StartsWith("https://google.com/", StringComparison.CurrentCultureIgnoreCase))
        {
            return _httpClient.GetStringAsync(requestUri);
        }
        else
        {
            Console.WriteLine("Can't get source from this Url.");
            return Task.Run(() => { return string.Empty; });
        }
    }
}
