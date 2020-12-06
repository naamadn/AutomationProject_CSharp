using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
    public class paymentMethodPage: commonOps
    {
        public IWebElement btn_payByBankWire
        {
            get
            {
                return driver.FindElement(By.CssSelector("a[class = 'bankwire"));
            }
        }
    }
}
