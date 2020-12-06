using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
    public class orderConfirmationPage: commonOps
    {
        public IWebElement lbl_confirmationTitle
        {
            get
            {
                return driver.FindElement(By.XPath("//p[@class = 'cheque-indent']"));
            }
        }
       
    }
}
