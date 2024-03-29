﻿using AutomationTraining_M7.Base_Files;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutomationTraining_M7
{
    class Program : BaseTest
    {
        static void Main(string[] args)
        {
            FnSendkeyAndClear(By.Name("userName"), ConfigurationManager.AppSettings.Get("username"));
            FnSendkeyAndClear(By.Name("password"), ConfigurationManager.AppSettings.Get("password"));

            //     FnSendkeyAndClear(By.XPath("//*[@name='userName']"), ConfigurationManager.AppSettings.Get("username"));
            //   FnSendkeyAndClear(By.XPath("//*[@name='password']"), ConfigurationManager.AppSettings.Get("password"));


            driver.FindElement(By.Name("login")).Click();

            IList<IWebElement> ElementList = driver.FindElements(By.XPath("//a"));

            foreach(IWebElement el in ElementList)
            {
                //el.Click();
                el.GetAttribute("href");
            }
        }
    }
}
