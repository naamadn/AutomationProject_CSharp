﻿using AutomationProject_CSharp.Extensions;
using AutomationProject_CSharp.Utilities;
using AutomationProject_CSharp.WorkFlows;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutomationProject_CSharp
{
    [Binding]
    public  class LoginSteps: commonOps
    {     
     
        [Given(@"I launch the website login page")]
        public void GivenILaunchTheLoginPage()
        {          
          uiActions.navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account");
        }        

        [Given(@"I enter the following details and click on login button")]
        public void GivenIEnterTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            webFlows.login(data.UserName, (data.Password).ToString());           

        }

        [Given(@"I click login button")]
        public void GivenIClickLoginButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see my account")]
        public void ThenIShouldSeeMyAccount()
        {
            //verifications.textInElement(driver.FindElement(By.XPath("//h1[@class = 'page-heading']")), "MY ACCOUNT");
            verifications.textInElement(myAccount_Page.title_myaccount, "MY ACCOUNT");
        }




    }
}