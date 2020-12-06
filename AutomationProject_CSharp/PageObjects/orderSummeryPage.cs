using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
    public class orderSummeryPage: commonOps
    {
        public IWebElement btn_confirm
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id= 'cart_navigation']/button/span"));
            }
        }
    }
}
