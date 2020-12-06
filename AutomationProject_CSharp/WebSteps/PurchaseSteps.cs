using AutomationProject_CSharp.Extensions;
using AutomationProject_CSharp.Utilities;
using AutomationProject_CSharp.WorkFlows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AutomationProject_CSharp
{
    [Binding]
    public class PurchaseSteps: commonOps
    {
        [When(@"I perform a purchase as a logged user")]
        public void WhenIPerformAPurchaseasaloggeduser()
        {
            webFlows.login("original.user@yandex.com", "123456");
            webFlows.perchase();
        }

        [Then(@"I get order complete message")]
        public void ThenIGetOrderCompleteMessage()
        {
            verifications.textInElement(orderConfirmation_Page.lbl_confirmationTitle, "Your order on My Store is complete.");
        }
    }

}

