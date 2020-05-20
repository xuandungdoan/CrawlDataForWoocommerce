using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebAutomation
{

    public class ListLink
    {

        //Constructor
        public ListLink()
        { }
        public static List<string> Run()
        {
            //Create new browser instance using IWebDriver
            IWebDriver browser = new ChromeDriver();

            //Redirect to site by URL
            List<string> linkproducts = new List<string>();

            linkproducts.Add("https://dosi-in.com/backpack/");


            List<string> linkProduct = new List<string>();

            foreach (var link in linkproducts)
            {
                browser.Navigate().GoToUrl(link);
                foreach (var element in browser.FindElements(By.CssSelector(".product-title-wrap .product-title")))
                {
                    linkProduct.Add(element.GetAttribute("href"));
                }
            }
            var count1 = 0;
            foreach (var link in linkProduct)
            {
                count1 = count1 + 1;
                Console.WriteLine("link san pham: " + link);
            }
            Console.WriteLine("so luong san pham: " + count1);

            browser.Close();
            //Close browser
            return linkProduct;
        }

    }
}
