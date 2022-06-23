using AutomationProject_CSharp.Extensions;
using AutomationProject_CSharp.Utilities;
using AutomationProject_CSharp.WorkFlows;
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
       

        [When(@"I login to website with valid credentials")]
        public void WhenILoginToWebsiteWithValidCredentials()
        {
            webFlows.login("original.user@yandex.com", "123456");
        }

        //[When(@"I login with valid credentials")]
        //public void WhenILoginWithValidCredentials()
        //{
        //   webFlows.login("original.user@yandex.com", "123456");
          
        //}

        [When(@"I mouse hover Dresses and select Summer Dresses")]
        public void WhenIMouseHoverDressesAndSelectSummerDresses()
        {
            uiActions.mouseHoverElements(catalogTopMenu_Page.opt_dresses, catalogTopMenu_Page.opt_summerDresses);
        }

        [When(@"I filter by small size")]
        public void WhenIFilterBySmallSize()
        {
            uiActions.checkItemInCheckBox(summerDresses_Page.chkbox_smallSize);         
        }

        [When(@"I filter by in stock items")]
        public void WhenIFilterByInStockItems()
        {
            uiActions.checkItemInCheckBox(summerDresses_Page.chk_inStock);         
        }

        [When(@"I sort by Price: Lowest first")]
        public void WhenISortByPriceLowestFirst()
        {
            uiActions.updateDropDown(summerDresses_Page.dropdown_sortBy, "Price: Lowest first");
        }

        [When(@"I select the first dress on the list")]
        public void WhenISelectTheFirstDressOnTheList()
        {
            uiActions.click(summerDresses_Page.Model_demo_5);
        }

        [When(@"I add item to cart")]
        public void WhenIAddItemToCart()
        {
            uiActions.click(ShoppingCart_Page.btn_Add_To_Cart);
        }

        [When(@"I proceed to checkout")]
        public void WhenIProceedToCheckout()
        {
            uiActions.click(summerDresses_Page.btn_proceedToCheckout);
            uiActions.click(ShoppingCart_Page.btn_proceedToCheckOut);
            uiActions.click(addresses_Page.btn_proceedToCheckout);
        }

        [When(@"I accept the terms of service and checkout")]
        public void WhenIAcceptTheTermsOfServiceAndCheckout()
        {
            uiActions.click(Shipping_Page.chkbox_termOfService);
            uiActions.click(Shipping_Page.btn_proceedToCheckout);
        }

        [When(@"I select paying method of BankWire")]
        public void WhenISelectPayingMethodOfBankWire()
        {
            uiActions.click(paymentMethod_Page.btn_payByBankWire);
        }

        [When(@"I confirm my order")]
        public void WhenIConfirmMyOrder()
        {
            uiActions.click(orderSummery_Page.btn_confirm);
        }




        [Then(@"I get order complete message")]
        public void ThenIGetOrderCompleteMessage()
        {
            verifications.textInElement(orderConfirmation_Page.lbl_confirmationTitle, "Your order on My Store is complete.");
        }
    }

}

