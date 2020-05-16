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
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAutomation
{
    public class Crawler
    {
        //Browser
        private IWebDriver browser;

        //Constructor
        public Crawler() 
        { }

        /// <summary>
        /// Run crawler
        /// </summary>
        /// <param name="productLinks">List of product links need to be crawled</param>
        /// <returns></returns>
        public List<Models.Product> Run(List<string> productLinks)
        {
            //Create new browser instance using IWebDriver
            browser = new ChromeDriver();

            //Create list of product for saving crawled data
            List<Models.Product> listProducts = new List<Models.Product>();

            //Get product information
            //  Iterate though each product link to get product information
            foreach (var link in productLinks)
            {
                var product = GetProductInformation(link);
                listProducts.Add(product);
            }

            //Close browser
            browser.Close();

            return listProducts;
        }

        /// <summary>
        /// Get product information
        /// </summary>
        /// <param name="productLink">Example: https://www.jomashop.com/tissot-watch-t0064071603300.html</param>
        private Models.Product GetProductInformation(string productLink)
        {
            //Create product to save crawled data
            Models.Product product = new Models.Product();

            //Redirect to site by URL
            //browser.Navigate().GoToUrl("https://www.jomashop.com/tissot-watch-t0064071603300.html");
            browser.Navigate().GoToUrl(productLink);

            //Select elements by CSS Selector (easiest way)
            //You can also select element by ID, Class, Name, XPath,...
            //Get brand by CSS Attribute Selectors (https://www.w3schools.com/css/css_attribute_selectors.asp)
            var element = browser.FindElement(By.CssSelector("[itemprop=\"brand manufacturer\"]>a"));
            product.Attribute1Value = element.GetAttribute("innerHTML"); //OuterHTML will give full element HTML code

            //Get price by CSS Selectors (https://www.w3schools.com/css/css_selectors.asp)
            element = browser.FindElement(By.CssSelector("#final-price")); //No timeout, wait until page loaded
            string finalPrice = element.GetAttribute("innerHTML");
            finalPrice = finalPrice.Replace("$", "");
            double finalPriceInVnd = Double.Parse(finalPrice) * 24300 * 1.1 + 350000;
            product.SalePrice = finalPriceInVnd;

       
            //----------------------------------------------

            return product;
        }
    }
}