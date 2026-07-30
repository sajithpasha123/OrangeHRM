using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace OrangeHRM.Utilities
{
    public static class ConfigReader
    {
        private static readonly IConfigurationRoot configuration;

        static ConfigReader()
        {
            configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();
        }

        public static string Browser =>
            configuration["Application:Browser"]!;

        public static string Environment =>
            configuration["Application:Environment"]!;

        public static string BaseUrl =>
            configuration[$"Urls:{Environment}"]!;
    }
}

