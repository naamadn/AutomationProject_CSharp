using AutomationProject_CSharp.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace AutomationProject_CSharp.Utilities
{
   public  class managePages: Base
    {
        
        public static void init()
        {
            authentication_Page = new authenticationPage();
            addresses_Page = new addressesPage();
            catalogTopMenu_Page = new catalogTopMenuPage();
            createAnAccount_Page = new createAnAccountPage();
            myAccount_Page = new myAccountPage();
            orderConfirmation_Page = new orderConfirmationPage();
            orderSummery_Page = new orderSummeryPage();
            paymentMethod_Page = new paymentMethodPage();
            Shipping_Page = new shippingPage();
            ShoppingCart_Page = new shoppingCartPage();
            summerDresses_Page = new summerDressesPage();
        }

    }
}
