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
            //var element = browser.FindElement(By.CssSelector("[itemprop=\"brand manufacturer\"]>a"));
            //product.Attribute1Value = element.GetAttribute("innerHTML"); //OuterHTML will give full element HTML code

            //Get price by CSS Selectors (https://www.w3schools.com/css/css_selectors.asp)
            //element = browser.FindElement(By.CssSelector("#final-price")); //No timeout, wait until page loaded
            //string finalPrice = element.GetAttribute("innerHTML");
            //finalPrice = finalPrice.Replace("$", "");
            //double finalPriceInVnd = Double.Parse(finalPrice) * 24300 * 1.1 + 350000;
            // product.SalePrice = finalPriceInVnd;

            string SKU = browser.FindElement(By.CssSelector(".product-short_description li:first-child")).GetAttribute("innerHTML");
            if (SKU != null)
            {
                product.SKU = SKU.Replace("Mã sản phẩm: ", "");
            }
            

            string Name = browser.FindElement(By.CssSelector("h1.mainbox-title")).GetAttribute("innerHTML");
            product.Name = Name;

            double finalPriceInVnd = Double.Parse(browser.FindElement(By.CssSelector(".price-num")).GetAttribute("innerHTML")) * 1.2 + 50000;
            product.SalePrice = finalPriceInVnd;

           // Có 6 PriceRange: > 2.000.000, 1.000.000 - 2.000.000, 500.000 - 1.000.000, 350.000 - 500.000, 150.000 - 350.000, 95.000 - 150.000
                string PriceRange = "";
            if (finalPriceInVnd > 2000000)
            {
                PriceRange = ">2000000";
            }
            if (finalPriceInVnd >= 1000000  && finalPriceInVnd <= 2000000)
            {
                PriceRange = "1.000.000 - 2.000.000";
            }
            if (finalPriceInVnd >= 350000 && finalPriceInVnd <= 500000)
            {
                PriceRange = "350.000 - 500.000";
            }
            if (finalPriceInVnd >= 150000 && finalPriceInVnd <= 350.000)
            {
                PriceRange = "150.000 - 350.000";
            }
            if (finalPriceInVnd >= 95000 && finalPriceInVnd <= 150000)
            {
                PriceRange = "95.000 - 150.000";
            }
            product.Attribute3Value = PriceRange;


            double retailPriceInVnd = Double.Parse(browser.FindElement(By.CssSelector(".strike span:first-child")).GetAttribute("innerHTML")) * 1.2 + 50000;
            product.RegularPrice = retailPriceInVnd;

            List<string> sizes = new List<string>();
            foreach (var size in browser.FindElements(By.CssSelector("label.radio.float-left.dosi_get_change_option.dosi_option_size")))
            {
                sizes.Add(size.GetAttribute("innerHTML").Trim().Replace(" ", "~"));
            }
            product.Attribute1Value = String.Join(", ", sizes);

            List<string> images = new List<string>();
            foreach (var image in browser.FindElements(By.CssSelector("a.cm-image-previewer.cm-previewer.previewer img")))
            {
                images.Add(image.GetAttribute("src").Replace(".webp", ""));
            }
            product.Images = String.Join(", ", images);

            //string Description = browser.FindElement(By.CssSelector(".tab-product .tab")).GetAttribute("outerHTML");
            //product.Description = Description.Trim().Replace(" ", "~");

            string brand = browser.FindElement(By.CssSelector("a.product_company")).GetAttribute("innerHTML");
            product.Attribute2Value = brand.Trim().Replace(" ", "~");

            
            product.Categories = "Brand>" + brand.Trim().Replace(" ", "~");

            // string shortDes = browser.FindElement(By.CssSelector(".cm-disable-empty-files.cm-processed-form ul.product-short_description")).GetAttribute("outerHTML");
            // product.ShortDescription = shortDes.Replace("DOSI", "VENUS").Trim().Replace(" ", "~");

            //----------------------------------------------

            return product;
        }
    }
}