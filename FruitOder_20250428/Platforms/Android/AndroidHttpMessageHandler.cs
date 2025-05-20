using System.Net.Security;
using FruitOder_20250428.Interfaces;
using Xamarin.Android.Net;

namespace FruitOder_20250428.Platforms.Android
{
    class AndroidHttpMessageHandler : IPlatformHttpMessageHandler
    {
        public HttpMessageHandler GetHttpMessageHandler() =>
            new AndroidMessageHandler
            {
                ServerCertificateCustomValidationCallback = (httpRequestMessage, certificate, chain, SslPolicyErrors) =>
                certificate?.Issuer == "CN-localhost" || SslPolicyErrors == SslPolicyErrors.None
            };
    }
}
