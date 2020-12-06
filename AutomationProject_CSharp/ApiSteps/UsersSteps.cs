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

namespace AutomationProject_CSharp.ApiSteps
{
    [Binding]
    public class UsersSteps : commonOps
    {


        //[When(@"I send a GET request to")]
        //public void WhenISendAGETRequestTo(Table table)
        //{
        //    dynamic data = table.CreateDynamicInstance();
        //    client = new RestClient(getData("Url_API") + data.API_Service);            
        //    client.Authenticator = new HttpBasicAuthenticator(getData("user_API"), getData("password_API"));
        //    httpRequest = new RestRequest(Method.GET);
        //    response = client.Execute(httpRequest);
        //    statusCode = response.StatusCode;
        //}

        [When(@"I send a GET request to ""(.*)""")]
        public void WhenISendAGETRequestTo(string api_ServiceUrl)
        {
            httpRequest = new RestRequest(api_ServiceUrl, Method.GET);
            response = client.Execute(httpRequest);
            statusCode = response.StatusCode;

        }



        [Then(@"I get OK response")]
        public void ThenIGetOKResponse()
        {
           
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

        }

        [When(@"I send a POST request to ""(.*)"" with the following params")]
        public void WhenISendAPOSTRequestToWithTheFollowingParams(string api_ServiceUrl, Table table)
        {
            dynamic data = table.CreateDynamicInstance();           
            httpRequest = new RestRequest(api_ServiceUrl, Method.POST);
            httpRequest.AddHeader("Content-Type", "application/json");
            httpRequest.RequestFormat = DataFormat.Json;
            httpRequest.AddJsonBody(new { data.Name, data.Email, data.Login, data.Password});
            response = client.Execute(httpRequest);
            statusCode = response.StatusCode;
        }

        [When(@"I send a PUT request to ""(.*)"" with the following params")]
        public void WhenISendAPUTRequestToWithTheFollowingParams(string api_ServiceUrl, Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            httpRequest = new RestRequest(api_ServiceUrl, Method.PUT);
            httpRequest.AddHeader("Content-Type", "application/json");
            httpRequest.RequestFormat = DataFormat.Json;
            httpRequest.AddJsonBody(new { data.Name, data.Email, data.Login, data.Password });
            response = client.Execute(httpRequest);
            statusCode = response.StatusCode;

        }

        [Then(@"I verify that the user name in ""(.*)"" was updated to ""(.*)""")]
        public void ThenIVerifyThatTheUserNameInWasUpdatedTo(string api_ServiceUrl, string name)
        {
            httpRequest = new RestRequest(api_ServiceUrl, Method.GET);
            response = client.Execute(httpRequest);
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);           
            string userName = jsonResponse.name;
            Assert.AreEqual(name, userName);
        }
       

        [When(@"I send a DELETE request to ""(.*)""")]
        public void WhenISendADELETERequestTo(string api_ServiceUrl)
        {
            httpRequest = new RestRequest(api_ServiceUrl, Method.DELETE);
            response = client.Execute(httpRequest);
            statusCode = response.StatusCode;
        }





    }
}
