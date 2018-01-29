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
        private IWebElement query;

        public void Web_Search_Test()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(https://www.google.com/)";

            IWebElement query = driver.FindElement(By.Id("lst-ib"));
            query.SendKeys("selenium hq");

            driver.Close();
        }
    }
}
