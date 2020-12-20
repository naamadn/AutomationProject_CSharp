using AutomationProject_CSharp.Extensions;
using AutomationProject_CSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.WorkFlows
{
    public class dbFlows : commonOps
    {
        public static void loginDB()
        {
            List<string> cred = dbActions.getCredentials("SELECT User_name, Password FROM Users WHERE id='5'");
            uiActions.click(catalogTopMenu_Page.btn_login);
            uiActions.updateText(authentication_Page.txt_email, cred[0]);
            uiActions.updateText(authentication_Page.txt_password, cred[1]);
            uiActions.click(authentication_Page.btn_login);
        }
    }
}
