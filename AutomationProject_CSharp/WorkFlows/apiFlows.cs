using System;
using System.Collections.Generic;
using System.Text;
using AutomationProject_CSharp.Extensions;
using AutomationProject_CSharp.Utilities;
using RestSharp;

namespace AutomationProject_CSharp.WorkFlows
{
    public class apiFlows : commonOps
    {
        public static dynamic getUserProperty(String jPath)
        {
            IRestResponse response = apiActions.get(jPath);
            return apiActions.extractFromJSON(response, jPath);
        }

        public static void postUser(String name, String email, String login, String password)
        {
            var body = new { name, email, login, password };
            apiActions.post(body, "/api/admin/users");
        }


        public static void updateUser(string api_ServiceUrl, string name, string email, string login, string password)
        {
            var body = new { name, email, login, password };
            apiActions.put(body, api_ServiceUrl);
        }

        public static void deleteUser(string api_ServiceUrl)
        {
            apiActions.delete(api_ServiceUrl);
        }
    }
}
