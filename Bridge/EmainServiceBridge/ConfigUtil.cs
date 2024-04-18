using Microsoft.Extensions.Configuration;

namespace Bridge.EmainServiceBridge
{
    internal class ConfigUtil
    {
        public static IConfiguration GetConfig()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddXmlFile("App.config.xml")
                .Build();

            return config;
        }

        public static string GetServiceName()
        {
            return GetConfig().GetSection("appSettings:MailService").Value;
        }
    }
}
