using AutomationProject_CSharp.Utilities;
using AutomationProject_CSharp.WorkFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationProject_CSharp.WebSteps
{
    [Binding]
    public class CommonSteps: commonOps
    {
        [When(@"I login with valid")]
        public void WhenILoginWithValid()
        {
            webFlows.login("original.user@yandex.com", "123456");
        }

       
    }
}
