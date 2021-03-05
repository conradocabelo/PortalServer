using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace StGate.InfraEstructure.EntityFramework
{
    public static class AppSettings
    {
        private static string _enviroment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

        private static IConfigurationRoot _configurationRoot = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .AddJsonFile($"appsettings.{_enviroment}.json", true)
            .AddEnvironmentVariables()
            .Build();

        public static string ConnectionString(string ConnectionName) =>
            _configurationRoot.GetConnectionString(ConnectionName);
    }
}
