/// <summary>
/// Copyright by Tin Trinh @ 2020
/// Project: Web Automation using Selenium WebDriver (ChromeDriver)
/// Background knowledge: Need to have
/// - Basic C# programming skill
/// - Skill to process data using Regular Expressions in C#
/// Guide:
/// - First, please update Nuget packages (Selenium WebDriver, Selenium Chrome Driver), Google Chrome to the latest version
/// - Run the demo code below to make sure everything works fine.
/// - Contact me at trinhtrongtinpp@gmail.com
/// </summary>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace WebAutomation
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            //Prepare list of product links
            List<string> productLinks = ListLink.Run();

            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            //Run Dosin crawler
            Crawler crawler = new Crawler();
            List<Models.Product> listProduct = crawler.Run(productLinks);

            //Generate WooCommerce Product Import template
           WooCommerceGenerator generator = new WooCommerceGenerator();
            generator.GenerateProductImportTemplate(listProduct, "D:\\woo.txt");
        } 
    }
}


