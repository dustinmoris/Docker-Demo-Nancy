namespace DockerDemoNancy.Host
{
    using System;
    using Nancy;

    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            var secret = Environment.GetEnvironmentVariable("Secret");

            Get["/"] = _ => "Nancy: Hello World";
            Get["/os"] = _ => Environment.OSVersion.ToString();
            Get["/secret"] = _ => secret ?? "not set";
        }
    }
}