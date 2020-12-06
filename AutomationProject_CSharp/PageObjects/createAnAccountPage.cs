using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
    public class createAnAccountPage : commonOps
    {
        public IWebElement radiobtn_Mr
        {
            get
            {
                return driver.FindElement(By.Id("id_gender1"));
            }
        }
        public IWebElement radiobtn_Mrs
        {
            get
            {
                return driver.FindElement(By.Id("id_gender2"));
            }
        }
        public IWebElement txt_firstName
        {
            get
            {
                return driver.FindElement(By.Id("customer_firstname"));
            }
        }
        public IWebElement txt_lastName
        {
            get
            {
                return driver.FindElement(By.Id("customer_lastname"));
            }
        }
        public IWebElement txt_email
        {
            get
            {
                return driver.FindElement(By.Id("email"));
            }
        }
        public IWebElement txt_password
        {
            get
            {
                return driver.FindElement(By.Id("passwd"));
            }
        }
        public IWebElement dropdown_days
        {
            get
            {
                return driver.FindElement(By.Id("days"));
            }
        }
        public IWebElement dropdown_months
        {
            get
            {
                return driver.FindElement(By.Id("months"));
            }
        }
        public IWebElement dropdown_years
        {
            get
            {
                return driver.FindElement(By.Id("years"));
            }
        }
        public IWebElement txt_firstNameForAddress
        {
            get
            {
                return driver.FindElement(By.Id("firstname"));
            }
        }
        public IWebElement txt_lastNameForAddress
        {
            get
            {
                return driver.FindElement(By.Id("lastname"));
            }
        }
        public IWebElement txt_company
        {
            get
            {
                return driver.FindElement(By.Id("company"));
            }
        }

        public IWebElement txt_addressMandatory
        {
            get
            {
                return driver.FindElement(By.Id("address1"));
            }
        }
        public IWebElement txt_city
        {
            get
            {
                return driver.FindElement(By.Id("city"));
            }
        }

        public IWebElement dropdown_state
        {
            get
            {
                return driver.FindElement(By.Id("id_state"));
            }
        }
        public IWebElement dropdown_country
        {
            get
            {
                return driver.FindElement(By.Id("id_country"));
            }
        }
        public IWebElement txt_postcode
        {
            get
            {
                return driver.FindElement(By.Id("postcode"));
            }
        }
        public IWebElement txt_phone
        {
            get
            {
                return driver.FindElement(By.Id("phone"));
            }
        }
        public IWebElement txt_alias
        {
            get
            {
                return driver.FindElement(By.Id("alias"));
            }
        }
        public IWebElement btn_submitAccount
        {
            get
            {
                return driver.FindElement(By.Id("submitAccount"));
            }
        }

        public IWebElement title_createAnAccount
        {
            get
            {
                return driver.FindElement(By.XPath("//div[@id='noSlide']/h1"));
            }
        }
    }
}
