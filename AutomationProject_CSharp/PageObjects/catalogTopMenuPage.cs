using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
    public class catalogTopMenuPage: commonOps
    {
        public IWebElement opt_dresses
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[2]/a"));
            }
        }
        public IWebElement opt_summerDresses
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[2]/ul/li[3]/a"));
            }
        }

        public IWebElement dropdown_prodAtributes
        {
            get
            {
                return driver.FindElement(By.XPath("//div[@class = 'product-atributes']"));
            }
        }

        public IWebElement btn_orderCart
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='button_order_cart']/span"));
            }
        }

        public IWebElement btn_cart
        {
            get
            {
                return driver.FindElement(By.XPath("//div[@class = 'shopping_cart']/a"));
            }
        }

        public IWebElement btn_login
        {
            get
            {
                return driver.FindElement(By.CssSelector("a[class = 'login"));
            }
        }
        public IWebElement img_logo
        {
            get
            {
                return driver.FindElement(By.CssSelector("img[class = 'logo img-responsive"));
            }
        }

    }
}
