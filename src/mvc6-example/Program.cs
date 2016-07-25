using System.Collections;
using System.Diagnostics;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.WindowsServices;

namespace mvc6_example
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var isDebug = Debugger.IsAttached || ((IList)args).Contains("--debug");

            if (isDebug)
            {
                var host = new WebHostBuilder()
                     .UseKestrel()
                     .UseContentRoot(Directory.GetCurrentDirectory())
                     .UseIISIntegration()
                     .UseStartup<Startup>()
                     .Build();

                host.Run();
            }
            else
            {
                var exePath = Process.GetCurrentProcess().MainModule.FileName;
                var directoryPath = Path.GetDirectoryName(exePath);

                var host = new WebHostBuilder()
                                .UseKestrel()
                                .UseContentRoot(directoryPath)
                                .UseStartup<Startup>()
                                .Build();

                host.RunAsService();
            }
        }
    }
}