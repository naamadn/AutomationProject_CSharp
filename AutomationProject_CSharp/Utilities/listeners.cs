using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.Utilities
{
   public  class listeners: commonOps, ITestListener
    {        
        public void TestOutput(TestOutput output)
        {
            Console.WriteLine("----------- Test output" + output.Text + "---------");
        }

        public void TestFinished(ITestResult result)
        {
            Console.WriteLine("----------- Test finished" + result.Output + "---------");

        }

        public void TestStarted(ITest test)
        {
            Console.WriteLine("-----------Starting Test "+ test.Name+"---------");
        }

        public void SendMessage(TestMessage message)
        {
            Console.WriteLine("-----------Starting Test " + message.ToString() + "---------");
        }     
             
       

    }
}
