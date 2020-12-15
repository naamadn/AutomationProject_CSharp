using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace AutomationProject_CSharp.Extensions
{
    public class uiActions: commonOps
    {
       
        public static void click(IWebElement elem)
        {
            wait.Until(driver => elem.Displayed);
            elem.Click();
        }

        public static void updateText(IWebElement elem, String value)
        {
            wait.Until(driver => elem.Displayed);
            elem.SendKeys(value);
        }

        public static void navigate(String path)
        {
            driver.Navigate().GoToUrl(path);
        }
        public static void mouseHoverElements(IWebElement elem1, IWebElement elem2)
        {            
            action.MoveToElement(elem1).MoveToElement(elem2).Click().Build().Perform();
        }

        public static void checkItemInCheckBox(IWebElement elem)
        {
            elem.Click();
        }

        public static void checkItemInRadioButton(IWebElement elem)
        {
            elem.Click();
        }
        public static void updateDropDown(IWebElement elem, String value)
        {            
            SelectElement myValue = new SelectElement(elem);
            myValue.SelectByText(value);
        }
        public static void addToCart(IWebElement elem)
        {
            uiActions.mouseHoverElements(elem, summerDresses_Page.btn_addToCart);
        }       

    }
}
