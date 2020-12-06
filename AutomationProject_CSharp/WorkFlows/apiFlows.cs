using System;
using System.Collections.Generic;
using System.Text;
using AutomationProject_CSharp.Extensions;
using AutomationProject_CSharp.Utilities;
using RestSharp;

namespace AutomationProject_CSharp.WorkFlows
{
    public class apiFlows: commonOps
    {
        public static string getUserProperty(String jPath)
        {
            IRestResponse response = apiActions.get("/api/users/");
            return apiActions.extractFromJSON(response, jPath);
        }
    }
}
