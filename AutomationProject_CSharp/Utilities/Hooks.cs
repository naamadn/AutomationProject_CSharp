using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Reflection;
using OpenQA.Selenium.Remote;
using TechTalk.SpecFlow;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Configuration;
using System;
using AventStack.ExtentReports.Reporter.Configuration;
using NUnit.Framework;
using AutomationProject_CSharp.Utilities;

namespace AutomationProject_CSharp
{
    [Binding]
    public class Hooks : commonOps
    {
        //Global Variable for Extend report
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        // private static KlovReporter klov;       

        private readonly IObjectContainer _objectContainer;

        //public static IWebDriver _driver;


        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }
       

        public static string Capture(IWebDriver _driver, string ScreenShotName)
        {
            ITakesScreenshot ts = (ITakesScreenshot)_driver;
            Screenshot screenshot = ts.GetScreenshot();
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string uptobinpath = path.Substring(0, path.LastIndexOf("bin")) + "Screenshots\\" + ScreenShotName + ".png";           
            string localPath = new Uri(uptobinpath).LocalPath;
            screenshot.SaveAsFile(localPath, ScreenshotImageFormat.Png);
            return localPath;
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(@"C:\Users\naama\Documents\OOP\AutomationProject_CSharp2\AutomationProject_CSharp\AutomationProject_CSharp\ExtentReport.html", ViewStyle.Default);
            // ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter("ExtentReport.html");
            // htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;

            //Attach report to reporter
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);


        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            //Flush report once test completes
            extent.Flush();
        }

        

        [BeforeFeature]
        public static void BeforeFeature()
        {
            //Create dynamic feature name          
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            startSession();
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            CloseSession();
        }

        

        [AfterStep]
        public void InsertReportingSteps()
        {

            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("ScenarioExecutionStatus", BindingFlags.Instance | BindingFlags.Public);
            MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            object TestResult = getter.Invoke(ScenarioContext.Current, null);

            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                {
                    if (logger == null)
                        scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                    else
                        scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Info(logger.ToString());

                }
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (ScenarioContext.Current.TestError != null)
            {
                screenShot = Guid.NewGuid().ToString();
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string screenshotpath = Capture(driver, screenShot);
                    scenario.AddScreenCaptureFromPath(screenshotpath);
                }
                else if (stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string screenshotpath = Capture(driver, screenShot);
                    scenario.AddScreenCaptureFromPath(screenshotpath);
                }
                else if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
                    string screenshotpath = Capture(driver, screenShot);
                    scenario.AddScreenCaptureFromPath(screenshotpath);                 
                 }
            }

            //Pending Status
            if (TestResult.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");

            }
          

        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            //Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
           // startSession();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            if (!getData("PlatformName").Equals("api"))
            {
                string screenshotpath = Capture(driver, screenShot);
               featureName.AddScreenCaptureFromPath(screenshotpath);              
            }
           // CloseSession();

        }

     

    }

   
}