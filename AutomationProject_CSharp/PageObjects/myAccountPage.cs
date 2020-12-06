using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
    public class myAccountPage: commonOps
    {
        public IWebElement title_myaccount
        {
            get
            {
                return driver.FindElement(By.XPath("//h1[@class = 'page-heading']"));
            }
        }
        public IWebElement btn_logOut
        {
            get
            {
                return driver.FindElement(By.XPath("//a[@class = 'logout']"));
            }
        }
    }
}
