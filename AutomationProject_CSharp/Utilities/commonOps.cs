
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using RestSharp;
using RestSharp.Authenticators;
using OpenQA.Selenium.Interactions;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace AutomationProject_CSharp.Utilities
{
  
    public class commonOps: Base
    {

        public static void initFromJson()
        {
            
          //  JObject obj = JObject.Parse(@"C:\Users\naamadn\Documents\OOP\AutomationProject_CSharp\AutomationProject_CSharp\AutomationProject_CSharp\appSettings.json");
          //   PlatformType = (string)obj["PlatformType"];

            var myJsonString = File.ReadAllText(@"C:\Users\naamadn\Documents\OOP\AutomationProject_CSharp\AutomationProject_CSharp\AutomationProject_CSharp\appSettings.json");
            var myJObject = JObject.Parse(myJsonString);
            //  Console.WriteLine(myJObject.SelectToken("MyStringProperty").Value<string>());
           
            // PlatformType = (string)myJObject["PlatformType"];

        }

        public static string getData(String nodeName)
        {            
            XmlDocument doc = new XmlDocument();
            string newNodeName;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\naama\Documents\OOP\AutomationProject_CSharp2\AutomationProject_CSharp\AutomationProject_CSharp\DataConfiguration.xml", Encoding.UTF8))
            {
                newNodeName = streamReader.ReadToEnd();
            }
            doc.LoadXml(newNodeName);
            XmlNode node = doc.GetElementsByTagName(nodeName).Item(0);

            return node.InnerText.ToString();                       

        }


        
        public void startSession()
        {

            if (getData("PlatformName").Equals("Web"))
            {
                initBrowser(getData("BrowserName"));

            }
            else if (getData("PlatformName").Equals("api"))
            {
                initAPI();
            }
        }
      

        private void initBrowser(string browserType)
        {
            switch (browserType.ToLower())
            {
                case "chrome":
                    driver = initChromeDriver();
                    break;              
                 
                    
            }

            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(getData("WebsiteUrl"));
            TimeSpan timeSpan = TimeSpan.FromSeconds(Double.Parse(getData("TimeOut")));
            driver.Manage().Timeouts().ImplicitWait = timeSpan;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Double.Parse(getData("TimeOut"))));
            action = new Actions(driver);
            managePages.init();
        }

        public IWebDriver initChromeDriver()
        {            
            IWebDriver driver = new ChromeDriver(getData("ChromeDriverLocation"));
            return driver;
        }

        public static void initAPI()
        {           
            client = new RestClient(getData("Url_API"));
            client.Authenticator = new HttpBasicAuthenticator(getData("user_API"), getData("password_API"));
        }


        public void CloseSession()
        {
            if (!getData("PlatformName").Equals("api"))
                driver.Quit();

        }


    }
}
