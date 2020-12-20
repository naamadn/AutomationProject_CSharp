using AutomationProject_CSharp.Utilities;
using AutomationProject_CSharp.WorkFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationProject_CSharp.DBSteps
{
    [Binding]
    public class dbTestsSteps : commonOps
    {
        [When(@"I login with credentials from DB")]
        public void WhenILoginWithCredentialsFromDB()
        {
            dbFlows.loginDB();
        }

    }
}
