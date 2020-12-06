using AutomationProject_CSharp.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace AutomationProject_CSharp
{
    public class Tests : commonOps
    {      

      //  [Test]
        public void Test1()
        {
            // Assert.Pass();
         //   driver.Navigate().GoToUrl(getData("WebsiteUrl"));
            driver.FindElement(By.XPath("//div[@id = 'contact-link']/a")).Click();
           

        }
       
    }
}