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
            linkproducts.Add("https://dosi-in.com/top/");
            linkproducts.Add("https://dosi-in.com/top/page-2/");
            linkproducts.Add("https://dosi-in.com/top/page-3/");
            linkproducts.Add("https://dosi-in.com/top/page-4/");
            linkproducts.Add("https://dosi-in.com/top/page-5/");
            linkproducts.Add("https://dosi-in.com/top/page-6/");
            linkproducts.Add("https://dosi-in.com/top/page-7/");
            linkproducts.Add("https://dosi-in.com/top/page-8/");
            linkproducts.Add("https://dosi-in.com/top/page-9/");
            linkproducts.Add("https://dosi-in.com/top/page-10/");
            linkproducts.Add("https://dosi-in.com/top/page-11/");
            linkproducts.Add("https://dosi-in.com/top/page-12/");
            linkproducts.Add("https://dosi-in.com/top/page-13/");
            linkproducts.Add("https://dosi-in.com/top/page-14/");
            linkproducts.Add("https://dosi-in.com/top/page-15/");
            linkproducts.Add("https://dosi-in.com/top/page-16/");
            linkproducts.Add("https://dosi-in.com/top/page-17/");
            linkproducts.Add("https://dosi-in.com/top/page-18/");
            linkproducts.Add("https://dosi-in.com/top/page-19/");
            linkproducts.Add("https://dosi-in.com/top/page-20/");
            linkproducts.Add("https://dosi-in.com/outer/");
            linkproducts.Add("https://dosi-in.com/outer/page-2/");
            linkproducts.Add("https://dosi-in.com/outer/page-3/");
            linkproducts.Add("https://dosi-in.com/outer/page-4/");
            linkproducts.Add("https://dosi-in.com/bottom/");
            linkproducts.Add("https://dosi-in.com/bottom/page-2/");
            linkproducts.Add("https://dosi-in.com/bottom/page-3/");
            linkproducts.Add("https://dosi-in.com/bottom/page-4/");
            linkproducts.Add("https://dosi-in.com/bottom/page-5/");
            linkproducts.Add("https://dosi-in.com/bottom/page-6/");
            linkproducts.Add("https://dosi-in.com/bottom/page-7/");
            linkproducts.Add("https://dosi-in.com/bag/");
            linkproducts.Add("https://dosi-in.com/bag/page-2/");
            linkproducts.Add("https://dosi-in.com/bag/page-3/");
            linkproducts.Add("https://dosi-in.com/bag/page-4/");
            linkproducts.Add("https://dosi-in.com/bag/page-5/");
            linkproducts.Add("https://dosi-in.com/bag/page-6/");
            linkproducts.Add("https://dosi-in.com/bag/page-7/");
            linkproducts.Add("https://dosi-in.com/sneaker/");
            linkproducts.Add("https://dosi-in.com/acc/");
            linkproducts.Add("https://dosi-in.com/acc/page-2/");
            linkproducts.Add("https://dosi-in.com/acc/page-3/");
            linkproducts.Add("https://dosi-in.com/acc/page-4/");
            linkproducts.Add("https://dosi-in.com/acc/page-5/");
            linkproducts.Add("https://dosi-in.com/acc/page-6/");
            linkproducts.Add("https://dosi-in.com/acc/page-7/");


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
