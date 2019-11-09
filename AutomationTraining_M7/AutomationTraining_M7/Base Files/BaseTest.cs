using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationTraining_M7.Base_Files
{
    class BaseTest
    {
        public static IWebDriver driver;

        //URL for Webdriver
        private static string strBrowserName = ConfigurationManager.AppSettings.Get("url");

        [SetUp]
        //Methods
        public static void SetUp()
        {
            driver = new ChromeDriver();
            driver.Url = strBrowserName;
        }

        [TearDown]
        public static void AfterTest()
        {
            driver.Close();
            driver.Quit();
        }

        public static void FnSendkeyAndClear(By by, string pstrText)
        {
            driver.FindElement(by).Clear();
            driver.FindElement(by).SendKeys(pstrText);
        }
    }
}
