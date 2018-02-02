using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Search
{
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com");
            IWebElement element = driver.FindElement(By.Name("lst-ib"));
            element.SendKeys("Selenium HQ");


            driver.Close();
        }
    }
}