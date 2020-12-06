using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
    public class addressesPage: commonOps
    {
        public IWebElement btn_proceedToCheckout
        {
            get
            {
                return driver.FindElement(By.Name("processAddress"));
            }
        }
    }
}
