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
            string runPath;

            if (isDebug)
                runPath = Directory.GetCurrentDirectory();
            else
            {
                var exePath = Process.GetCurrentProcess().MainModule.FileName;
                runPath = Path.GetDirectoryName(exePath);
            }

            var host = new WebHostBuilder()
                            .UseKestrel()
                            .UseContentRoot(runPath)
                            .UseStartup<Startup>()
                            .Build();

            if (isDebug)
                host.Run();
            else
                host.RunAsService();
        }
    }
}