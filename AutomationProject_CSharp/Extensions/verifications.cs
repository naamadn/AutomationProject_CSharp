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
            // assertEquals(elem.Text, expectedValue);
            Assert.AreEqual(elem.Text, expectedValue);

        }

        public static void text(String actualText, String expectedText)
        {
            Assert.AreEqual(actualText, expectedText);
        }

        public static void statusCodeIn(HttpStatusCode expectedCode, HttpStatusCode actualCode)
        {
            Assert.AreEqual(expectedCode, actualCode);
        }


    }
}
