using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace ArrayInAppSettingsTest
{
    static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, options) =>
                {
                    var configuration = options
                            .AddJsonFile("appsettings.Debug.json")
                            .Build();

                    // I would expect it would retrieve a value from appsettings.Debug.json, but because
                    // SomeArray array in appsettings.Debug.json is empty, it takes value from appsettings.Production.json
                    var brokenValue = configuration.GetSection("SomeArray").Get<string[]>();
                    Console.WriteLine(String.Join(',', brokenValue));
                    Console.ReadLine();
                });
        }
    }
}