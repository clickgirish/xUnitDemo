using Business;
using Business.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessExecutor
{
    public static class Program
    {
        static void Main()
        {
            // Step 1: Build the configuration
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Set the base path for the application
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true) // Add the appsettings.json file
                .Build();

            // Step 2: Get the connection string from configuration
            string connectionString = config.GetConnectionString("DefaultConnection");

            // Step 3: Configure DbContext options
            var optionsBuilder = new DbContextOptionsBuilder<MangoProductAPIContext>();
            optionsBuilder.UseSqlServer(connectionString);

            StaticParamLogic logic = new StaticParamLogic(optionsBuilder.Options);
            var staticParam = logic.GetParamById("Param1");

            if (staticParam != null)
                Console.WriteLine(staticParam.Value);
            else
                Console.WriteLine(" Static Param not found");

            Console.ReadLine();
        }

        private static IConfiguration BuildConfigurations()
        {
            // Build the configuration
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  // Set the base path for the application
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true) // Add the appsettings.json file
                .Build();

            return config;
        }
    }
}
