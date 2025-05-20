using FruitOder_20250428.Interfaces;
using Security;

namespace FruitOder_20250428.Platforms.iOS
{
    public class IosHttpMessageHandler : IPlatformHttpMessageHandler
    {
        public HttpMessageHandler GetHttpMessageHandler() =>
            new NSUrlSessionHandler
            {
                TrustOverrideForUrl = (NSUrlSessionHandler sender, string url, SecTrust trust)
                => url.StartsWith("https://localhost")
            };
    }
}
