//using System;
//using Microsoft.Extensions.Configuration;

//namespace AboutMeWebsite
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Set up configuration to read the connection string from appsettings.json
//            var configuration = new ConfigurationBuilder()
//                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
//                .AddJsonFile("appsettings.json")
//                .Build();

//            // Create an instance of the WidgetService
//            var widgetService = new WidgetService(configuration);

//            // Data to insert into database
//            //string name = "SampleWidget";
//            //string manufacturer = "WidgetCorp";
//            //string partNumber = "W123";
//            //int cost = 299;

//            //// Insert the widget data into the database
//            //widgetService.InsertWidget(name, manufacturer, partNumber, cost);

//            //// Inform the user
//            //Console.WriteLine("Widget inserted successfully.");


//            //Data to Update in database
//            int idToUpdate = 20; // The ID of the widget to update
//            string updatedName = "UpdatedSampleWidget";
//            string updatedManufacturer = "UpdatedWidgetCorp";
//            string updatedDescription = "An updated sample widget description";
//            int updatedCost = 399;

//            // Update the widget data in the database
//            widgetService.UpdateWidget(idToUpdate, updatedName, updatedManufacturer, updatedDescription, updatedCost);

//            // Inform the user
//            Console.WriteLine("Widget updated successfully.");
//        }
//    }
//}
//above code is for manually inserting into database

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;

namespace AboutMeWebsite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
