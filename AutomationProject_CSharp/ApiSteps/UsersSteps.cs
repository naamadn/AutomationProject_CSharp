using AutomationProject_CSharp.Utilities;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using RestSharp.Authenticators;
using NUnit.Framework;
using System.Net;
using Newtonsoft.Json;
using AutomationProject_CSharp.Extensions;
using AutomationProject_CSharp.WorkFlows;

namespace AutomationProject_CSharp.ApiSteps
{
    [Binding]
    public class UsersSteps : commonOps
    {
        dynamic usersList;

        [When(@"I send a GET request to ""(.*)""")]
        public void WhenISendAGETRequestTo(string api_ServiceUrl)
        {
            usersList = apiFlows.getUserProperty(api_ServiceUrl);
        }

        [Then(@"I print the first user details")]
        public void ThenIPrintTheFirstUserDetails()
        {
            Console.WriteLine(usersList[0]);
        }

        [Then(@"I print user details where id is ""(.*)""")]
        public void ThenIPrintUserDetailsWhereIdIs(int id)
        {
            for (int i = 0; ; i++)
            {
                if (usersList[i].id == id)
                {
                    logger = usersList[i];
                    Console.WriteLine(usersList[i]);
                    break;
                }
            }
        }

        [Then(@"I get OK response")]
        public void ThenIGetOKResponse()
        {
            verifications.statusCodeIn(HttpStatusCode.OK, statusCode);
        }

        [When(@"I send a POST request to ""(.*)"" with the following params")]
        public void WhenISendAPOSTRequestToWithTheFollowingParams(string api_ServiceUrl, Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            apiFlows.postUser(data.Name, data.Email, data.Login, data.Password);

        }

        [When(@"I send a PUT request to ""(.*)"" with the following params")]
        public void WhenISendAPUTRequestToWithTheFollowingParams(string api_ServiceUrl, Table table)
        {
            usersList = apiFlows.getUserProperty(api_ServiceUrl);
            dynamic data = table.CreateDynamicInstance();
            apiFlows.updateUser(api_ServiceUrl, data.Name, data.Email, data.Login, data.Password);
        }

        [Then(@"I verify that the user name in ""(.*)"" was updated to ""(.*)""")]
        public void ThenIVerifyThatTheUserNameinWasUpdatedTo(string api_ServiceUrl, string name)
        {
            string username = string.Empty;

            usersList = apiFlows.getUserProperty(api_ServiceUrl);
            username = usersList.name;
            verifications.text(name, username);           
        }


        [When(@"I send a DELETE request to ""(.*)""")]
        public void WhenISendADELETERequestTo(string api_ServiceUrl)
        {
            apiFlows.deleteUser(api_ServiceUrl);
        }





    }
}
