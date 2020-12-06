using AutomationProject_CSharp.Extensions;
using AutomationProject_CSharp.Utilities;
using AutomationProject_CSharp.WorkFlows;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp
{
    [TestFixture]
    public class AutoPractiseWeb: commonOps
    {        

       // [Test]
        public void test01_login()
        {
           // driver = new ChromeDriver();

           // driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            webFlows.login("original.user@yandex.com", "123456");
            verifications.textInElement(driver.FindElement(By.XPath("//h1[@class = 'page-heading']")), "MY ACCOUNT");

        }


    }
}
