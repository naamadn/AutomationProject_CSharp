using AutomationProject_CSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AutomationProject_CSharp.Extensions
{
    public class apiActions : commonOps
    {

        //Get Data From Server
        public static IRestResponse get(String paramValues)
        {
            client = new RestClient(getData("Url_API") + paramValues);
            client.Authenticator = new HttpBasicAuthenticator(getData("user_API"), getData("password_API"));
            httpRequest = new RestRequest(Method.GET);
            response = client.Execute(httpRequest);
            return response;
        }

        public static String extractFromJSON(IRestResponse response, String path)
        {
            string propertyValue = string.Empty;

            // jp = response.jsonPath();
            // return jp.get(path).toString();
          
           


            jsonArray = JArray.Parse(response.Content);
                foreach (JObject parsedObject in jsonArray.Children<JObject>())           
                {
                foreach (JProperty parsedProperty in parsedObject.Properties())
                {
                    string propertyName = parsedProperty.Name;
                    if (propertyName.Equals(path))
                    {
                        propertyValue = (string)parsedProperty.Value;
                        Console.WriteLine("Name: {0}, Value: {1}", propertyName, propertyValue);
                    }
                }
            }
            return propertyValue;


        }



    }
}
