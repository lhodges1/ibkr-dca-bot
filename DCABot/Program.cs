using System;
using Serilog;
using Microsoft.Extensions.Configuration;

namespace Program
{
    class Program
    {
        private IConfiguration Configuration;
        public static void Main(string[] args)
        {
            //Configure logger
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs.txt")
                .CreateLogger();

            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddInMemoryCollection("appsettings.json");
        }
    }
}