using AutomationProject_CSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using NUnit.Framework;
using RestSharp.Authenticators;
using RestSharp.Serialization.Json;
using System.Net;
using AutomationProject_CSharp.WorkFlows;
using Newtonsoft.Json.Linq;
using AutomationProject_CSharp.Extensions;
using Newtonsoft.Json;

namespace AutomationProject_CSharp
{
    [TestFixture]
    public class apiTest : commonOps
    {
        RestClient myclient;


        // [OneTimeSetUp]
        public void start()
        {
            myclient = new RestClient(getData("Url_API"));
            myclient.Authenticator = new HttpBasicAuthenticator(getData("user_API"), getData("password_API"));
        }

        // [Test]
        public void get()
        {
            var myrequest = new RestRequest("/api/users/", Method.GET);
            //myrequest.AddUrlSegment("id", 1);
            string mycontent = myclient.Execute(myrequest).Content;
            Console.WriteLine(mycontent);

        }

      //  [Test]
        public void get1()
        {
            // RestClient client = new RestClient("/api/users/");
            RestClient client = new RestClient(getData("Url_API") + "/api/users/");
            client.Authenticator = new HttpBasicAuthenticator(getData("user_API"), getData("password_API"));

            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            var statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

        }


      //  [Test]
        public void get2()
        {
            // RestClient client = new RestClient("/api/users/");
            RestClient client = new RestClient(getData("Url_API") + "/api/users/");
            client.Authenticator = new HttpBasicAuthenticator(getData("user_API"), getData("password_API"));

            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            string res = response.Content;
            JArray jsonArray = JArray.Parse(response.Content);

            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            var users = jsonResponse.Root;
            var userId = jsonResponse.Root[0].id;


            foreach (JObject parsedObject in jsonArray.Children<JObject>())
            {
                foreach (JProperty parsedProperty in parsedObject.Properties())
                {
                    string propertyName = parsedProperty.Name;
                    if (propertyName.Equals("login"))
                    {
                        string propertyValue = (string)parsedProperty.Value;
                        Console.WriteLine("Name: {0}, Value: {1}", propertyName, propertyValue);
                    }
                }
            }




        }

      //  [Test]
        public void post1()
        {
            string name = "User4";
            string email = "User4@user.com";
            string login = "User4";
            string password = "1234";
            var client = new RestClient(getData("Url_API") + "/api/admin/users");
            client.Authenticator = new HttpBasicAuthenticator(getData("user_API"), getData("password_API"));
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { name, email, login, password });
            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

        }

      //  [Test]
        public void put()
        {
            string name = "User8";
            string email = "User2@user.com";
            string login = "User2";
            string password = "1234";
            var client = new RestClient(getData("Url_API") + "/api/users/8");
            client.Authenticator = new HttpBasicAuthenticator(getData("user_API"), getData("password_API"));
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(new { name, email, login, password });
            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);

            // string statusMsg = response.Content;
            // Assert.AreEqual("message:User updated", statusMsg);

        }

      //  [Test]
        public void delete()
        {
            var client = new RestClient(getData("Url_API") + "/api/admin/users/8");
            client.Authenticator = new HttpBasicAuthenticator(getData("user_API"), getData("password_API"));
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = client.Execute(request);

            var statusCode = response.StatusCode;
            Assert.AreEqual(HttpStatusCode.OK, statusCode);



        }

        // [Test]
        public void post()
        {
            var myrequest = new RestRequest("/api/auth/keys", Method.POST);
            myrequest.RequestFormat = DataFormat.Json;
            myrequest.AddJsonBody(new { name = "mykey1" });
            myrequest.AddJsonBody(new { role = "admin" });
            var myresponse = myclient.Execute(myrequest);
            var deser = new JsonDeserializer();
            var outpout = deser.Deserialize<Dictionary<string, string>>(response);
            var result = outpout["name"];


        }

      //  [Test]
        public void getproperty()
        {
            apiFlows.getUserProperty("[0].login");
        }

      //  [Test]
        public void test01_getUsersList()
        {
           verifications.text(apiFlows.getUserProperty("login"), "admin");
        }

    }
}
