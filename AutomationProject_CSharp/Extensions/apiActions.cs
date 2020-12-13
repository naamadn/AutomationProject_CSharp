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
            httpRequest = new RestRequest(paramValues, Method.GET);
            response = client.Execute(httpRequest);
            statusCode = response.StatusCode;
            return response;
        }

        //Post Data To Server
        public static void post(dynamic jsonBody, String paramValues)
        {
            httpRequest = new RestRequest(paramValues, Method.POST);
            httpRequest.AddHeader("Content-Type", "application/json");
            httpRequest.RequestFormat = DataFormat.Json;
            httpRequest.AddJsonBody(jsonBody);
            response = client.Execute(httpRequest);
            statusCode = response.StatusCode;
        }

        // Update Data In Server
        public static void put(dynamic jsonBody, String paramValues)
        {
            httpRequest = new RestRequest(paramValues, Method.PUT);
            httpRequest.AddHeader("Content-Type", "application/json");
            httpRequest.RequestFormat = DataFormat.Json;
            httpRequest.AddJsonBody(jsonBody);
            response = client.Execute(httpRequest);
            statusCode = response.StatusCode;
        }

        //Delete Data From Server
        public static void delete(String api_ServiceUrl)
        {
            httpRequest = new RestRequest(api_ServiceUrl, Method.DELETE);
            response = client.Execute(httpRequest);
            statusCode = response.StatusCode;
        }

        //Extract Data From JSON
        public static dynamic extractFromJSON(IRestResponse response, String path)
        {           
            dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);
            return jsonResponse;       

        }



    }
}
