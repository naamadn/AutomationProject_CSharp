using AutomationProject_CSharp.PageObjects;
using AventStack.ExtentReports;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenQA.Selenium.Interactions;
using System.Net;
using MySqlConnector;

namespace AutomationProject_CSharp.Utilities
{
    public class Base
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;
        public static string WebsiteUrl;
        public static string PlatformType;
        public static string BrowserName;

        public static Actions action;

        public static IConfiguration _configuration;

        public static authenticationPage authentication_Page;
        public static addressesPage addresses_Page;
        public static catalogTopMenuPage catalogTopMenu_Page;
        public static createAnAccountPage createAnAccount_Page;
        public static myAccountPage myAccount_Page;
        public static orderConfirmationPage orderConfirmation_Page;
        public static orderSummeryPage orderSummery_Page;
        public static paymentMethodPage paymentMethod_Page;
        public static shippingPage Shipping_Page;
        public static shoppingCartPage ShoppingCart_Page;
        public static summerDressesPage summerDresses_Page;

        public static ExtentReports extent;

        public static ExtentTest test;

        public static RestRequest httpRequest;
        public static IRestResponse response;
        public static RestClient client;
        public static JArray jsonArray;
        public static HttpStatusCode statusCode;

        //  public static Guid g = new Guid();
        public static string screenShot = string.Empty;
        public static dynamic logger;

        public static MySqlConnection conn;








    }
}
