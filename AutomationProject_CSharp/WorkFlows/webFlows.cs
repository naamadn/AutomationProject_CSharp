using AutomationProject_CSharp.PageObjects;
using AutomationProject_CSharp.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using AutomationProject_CSharp.Extensions;
using OpenQA.Selenium;

namespace AutomationProject_CSharp.WorkFlows
{
   public  class webFlows: commonOps
    {
        public static void login(String user, String password)
        {
            //  uiActions.click(authenPage.btn_login);
            uiActions.navigate("http://automationpractice.com/index.php?controller=authentication&back=my-account");
            uiActions.updateText(authentication_Page.txt_email, user);
            uiActions.updateText(authentication_Page.txt_password, password);
            uiActions.click(authentication_Page.btn_login);
        }

        public static void perchase()
        {
            IList<IWebElement> listOfItems = summerDresses_Page.listOfProducts;
            uiActions.mouseHoverElements(catalogTopMenu_Page.opt_dresses, catalogTopMenu_Page.opt_summerDresses);
            uiActions.checkItemInCheckBox(summerDresses_Page.chkbox_smallSize);
            uiActions.checkItemInCheckBox(summerDresses_Page.chk_inStock);
            uiActions.updateDropDown(summerDresses_Page.dropdown_sortBy, "Price: Lowest first");
            uiActions.click(driver.FindElement(By.XPath("//*[@id='center_column']/ul/li[1]/div/div[1]/div/a[1]/img")));
            uiActions.click(driver.FindElement(By.XPath("//*[@id='add_to_cart']/button/span")));          
            uiActions.click(summerDresses_Page.btn_proceedToCheckout);         
            uiActions.click(ShoppingCart_Page.btn_proceedToCheckOut);
            uiActions.click(addresses_Page.btn_proceedToCheckout);            
            uiActions.click(Shipping_Page.chkbox_termOfService);
            uiActions.click(Shipping_Page.btn_proceedToCheckout);
            uiActions.click(paymentMethod_Page.btn_payByBankWire);
            uiActions.click(orderSummery_Page.btn_confirm);

        }

        public static void signUp(string email)
        {
            uiActions.updateText(authentication_Page.txt_emailCreate, email);
            uiActions.click(authentication_Page.btn_createAccount);
           
        }

        public static void createAnAccount(string title, string firstName, string lastName, string password, string address, string city, string state, string zip, string phone)
        {
            if (title.Equals("Mr"))
                uiActions.checkItemInRadioButton(createAnAccount_Page.radiobtn_Mr);
            else
                uiActions.checkItemInRadioButton(createAnAccount_Page.radiobtn_Mrs);

            uiActions.updateText(createAnAccount_Page.txt_firstName, firstName);
            uiActions.updateText(createAnAccount_Page.txt_lastName, lastName);
            uiActions.updateText(createAnAccount_Page.txt_password, password);
            uiActions.updateText(createAnAccount_Page.txt_firstNameForAddress, firstName);
            uiActions.updateText(createAnAccount_Page.txt_lastNameForAddress, lastName);
            uiActions.updateText(createAnAccount_Page.txt_addressMandatory, address);
            uiActions.updateText(createAnAccount_Page.txt_city, city);
            uiActions.updateDropDown(createAnAccount_Page.dropdown_state, state);
            uiActions.updateText(createAnAccount_Page.txt_postcode, zip);          
            uiActions.updateText(createAnAccount_Page.txt_phone, phone);
            uiActions.click(createAnAccount_Page.btn_submitAccount);
        }
    }
}
