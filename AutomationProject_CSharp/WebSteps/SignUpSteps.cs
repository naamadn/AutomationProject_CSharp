using AutomationProject_CSharp.Extensions;
using AutomationProject_CSharp.Utilities;
using AutomationProject_CSharp.WorkFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace AutomationProject_CSharp.Steps
{
    [Binding]
    public class SignUpSteps : commonOps
    {
        [When(@"I sign up to website with the following email")]
        public void WhenISignUpToWebsitewithTheFollowingEmail(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            webFlows.signUp(data.Email);
        }


        [When(@"I create an account with the following details")]
        public void WhenICreateAnAccountWithTheFollowingDetails(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            webFlows.createAnAccount(data.Title, data.FirstName, data.LastName, (data.Password).ToString(), data.Address, data.City, data.State, (data.Zip).ToString(), (data.Phone).ToString());
        }

        [Then(@"I go to my account")]
        public void ThenIGoToMyAccount()
        {
            verifications.textInElement(myAccount_Page.title_myaccount, "MY ACCOUNT");
        }

        [Then(@"I get a message that email address has already been registered")]
        public void ThenIgetamessagethatemailaddresshasalreadybeenregistered()
        {
            verifications.textInElement(authentication_Page.msg_email_already_registered, "An account using this email address has already been registered. Please enter a valid password or request a new one.");
        }

    }
}
