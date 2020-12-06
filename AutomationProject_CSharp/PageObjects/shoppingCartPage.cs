using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
   public class shoppingCartPage: commonOps
    {
        public IWebElement btn_proceedToCheckOut
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id= 'center_column']/p[2]/a[1]/span"));
            }
        }
    }
}
