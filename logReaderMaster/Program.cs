﻿//using logReaderMaster.DAL;
//using logReaderMaster.DAL;
using logReaderMaster.DAL;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
namespace ConsoleApp
{
    class Program
    {

        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile(_iconfiguration);
            PrintCountries();
        }
        static void GetAppSettingsFile(IConfiguration _iconfiguration)
        {
            var builder = new ConfigurationBuilder()
                                 .SetBasePath(Directory.GetCurrentDirectory())
                                 .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void PrintCountries()
        {
            var countryDAL = new CountryDAL(_iconfiguration);
            var listCountryModel = countryDAL.GetList();
            listCountryModel.ForEach(item =>
            {
                Console.WriteLine(item.Country);
            });
            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
    }
}



