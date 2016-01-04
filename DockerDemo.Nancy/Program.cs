using Mono.Unix;
using Mono.Unix.Native;
using Nancy.Hosting.Self;
using System;

namespace DockerDemo.Nancy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string uri = "http://localhost:8888";

            Console.WriteLine("Starting Nancy on " + uri);

            var host = new NancyHost(new Uri(uri));
            host.Start();

            // Check if we're running on mono
            if (Type.GetType("Mono.Runtime") != null)
            {
                // On mono, processes will usually run as daemons - this allows you to listen
                // for termination signals (CTRL + C, Shutdown, etc.) and finalize correctly
                UnixSignal.WaitAny(new[] {
                    new UnixSignal(Signum.SIGINT),
                    new UnixSignal(Signum.SIGTERM),
                    new UnixSignal(Signum.SIGQUIT),
                    new UnixSignal(Signum.SIGHUP)
                });
            }
            else
            {
                Console.ReadLine();
            }

            Console.WriteLine("Stopping Nancy");
            host.Stop();
        }
    }
}
