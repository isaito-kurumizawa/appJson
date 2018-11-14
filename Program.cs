using System;
using System.IO;
using Microsoft.Extensions.Configuration;

// install
// dotnet add package Microsoft.Extensions.Configuration --version 2.1.1
// dotnet add package Microsoft.Extensions.Configuration.FileExtensions --version 2.1.1
// dotnet add package Microsoft.Extensions.Configuration.Json --version 2.1.1
namespace appJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var configBuilder = new ConfigurationBuilder();
            configBuilder.SetBasePath(Directory.GetCurrentDirectory());
            configBuilder.AddJsonFile(@"appsettings.json");
            var config = configBuilder.Build();

            var testValue = config["AppSettings:TestConstValue"];
            testValue = config.GetSection("AppSettings")["TestConstValue"];
            var hw = config.GetSection("HelloWorld");
            Console.WriteLine(hw.Value);
        }
    }
}
