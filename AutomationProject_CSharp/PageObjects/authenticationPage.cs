using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.PageObjects
{
    public class authenticationPage : commonOps
    {
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

        public IWebElement btn_login
        {
            get
            {
                return driver.FindElement(By.Id("SubmitLogin"));
            }
        }

        public IWebElement txt_emailCreate
        {
            get
            {
                return driver.FindElement(By.Id("email_create"));
            }
        }

        public IWebElement btn_createAccount
        {
            get
            {
                return driver.FindElement(By.XPath("//button[@class = 'btn btn-default button button-medium exclusive']"));
            }
        }

        public IWebElement msg_email_already_registered
        {
            get
            {
                return driver.FindElement(By.XPath("//*[@id='create_account_error']/ol/li"));
            }
        }



    }
}
