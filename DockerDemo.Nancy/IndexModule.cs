using System;
using Nancy;

namespace DockerDemo.Nancy
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            var secureKey = Environment.GetEnvironmentVariable("SecureKey");
            var environment = Environment.GetEnvironmentVariable("Environment");

            Get["/"] = _ => "Nancy: Hello World";
            Get["/os"] = _ => Environment.OSVersion.ToString();
            Get["/securekey"] = _ => secureKey;
            Get["/environment"] = _ => environment;
        }
    }
}