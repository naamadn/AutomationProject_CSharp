using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
    public class summerDressesPage : commonOps
    {
        public IWebElement chkbox_smallSize
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='layered_id_attribute_group_1']"));
            }
        }
        public IWebElement chk_inStock
        {
            get
            {
                return driver.FindElement(By.Id("layered_quantity_1"));
            }
        }
        public IWebElement dropdown_sortBy
        {
            get
            {
                return driver.FindElement(By.Id("selectProductSort"));
            }
        }
        public IList<IWebElement> listOfProducts
        {
            get
            {
                return driver.FindElements(By.XPath("//div[@class = 'product-container']"));

            }
        }

        public IWebElement btn_addToCart
        {
            get
            {
                return driver.FindElement(By.XPath("//a[@class = 'button ajax_add_to_cart_button btn btn-default']"));
            }
        }
        public IWebElement btn_proceedToCheckout
        {
            get
            {
                return driver.FindElement(By.XPath("//a[@class = 'btn btn-default button button-medium']"));
            }
        }

        public IWebElement Model_demo_5
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[1]/div/a[1]/img"));
            }
        }



    }
}
