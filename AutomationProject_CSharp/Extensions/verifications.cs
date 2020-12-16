using AutomationProject_CSharp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using System.Net;

namespace AutomationProject_CSharp.Extensions
{
    public class verifications : commonOps
    {
        public static void textInElement(IWebElement elem, String expectedValue)
        {           
            Assert.AreEqual(expectedValue, elem.Text); 
        }

        public static void text(String actualText, String expectedText)
        {
            Assert.AreEqual(actualText, expectedText);
        }

        public static void statusCodeIn(HttpStatusCode expectedCode, HttpStatusCode actualCode)
        {
            Assert.AreEqual(expectedCode, actualCode);
        }

        public static void isSelected(IWebElement elem)
        {
            Assert.True(elem.Selected);
        }


    }
}
