using AbelAndCole.PageObject;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AbelAndCole.StepDefinition
{
    [Binding]
    public class AddShoppingItemsSteps
    {
        WelcomePage welcomePage;
        LandingPage landingPage;
        SearchPage searchPage;
        OrderPage orderPage;

        public AddShoppingItemsSteps()
        {
            welcomePage = new WelcomePage();
            landingPage = new LandingPage();
            searchPage = new SearchPage();
            orderPage = new OrderPage();
        }



        [Given(@"that I navigate to ""(.*)""")]
        public void GivenThatINavigateTo(string Url)
        {
            welcomePage.NavigateToUrl(Url);
        }

        [Given(@"I click on accept to accept cookies")]
        public void GivenIClickOnAcceptToAcceptCookies()
        {
            Thread.Sleep(3000);
            welcomePage.Accept();
        }


        [Given(@"I enter the item name in the search bar ""(.*)""")]
        public void GivenIEnterTheItemNameInTheSearchBar(string Itemname)
        {
            welcomePage.SearchItem(Itemname);
        }
        
        [Given(@"I click on the search button")]
        public void GivenIClickOnTheSearchButton()
        {
            welcomePage.SearchButton();
        }
        
        [Given(@"I click on Add button")]
        public void GivenIClickOnAddButton()
        {
            landingPage.ClickOnAddButton();
        }

        [Given(@"I click on Addhumus  button")]
        public void GivenIClickOnAddhumusButton()
        {
            landingPage.ClickOnAddHummusButton();
        }

        [Given(@"I enter the item in the search bar ""(.*)""")]
        public void GivenIEnterTheItemInTheSearchBar(string Itemname)
        {
            searchPage.SearchItem(Itemname);
        }

        [Given(@"I click on search button")]
        public void GivenIClickOnSearchButton()
        {
            searchPage.SearchButton();
        }

        [Given(@"I click on plus button")]
        public void GivenIClickOnPlusButton()
        {
            landingPage.ClickOnPlusButton();
        }

        [Given(@"I click on plushummus button")]
        public void GivenIClickOnPlushummusButton()
        {
            landingPage.ClickOnPlusHummusButton();
        }

        [Given(@"I enter the popcorn item in the search bar ""(.*)""")]
        public void GivenIEnterThePopcornItemInTheSearchBar(string Itemnamepopcorn)
        {
            searchPage.SearchPopcorn(Itemnamepopcorn);
        }

        [Given(@"I click on searchpopcorn button")]
        public void GivenIClickOnSearchpopcornButton()
        {
            searchPage.PopcornSearchButton();
        }

        [Given(@"I click on Addpopcorn button")]
        public void GivenIClickOnAddpopcornButton()
        {
            landingPage.ClickOnAddPopcorn();
        }

        [Given(@"I click on pluspopcorn button")]
        public void GivenIClickOnPluspopcornButton()
        {
            landingPage.ClickOnPlusPopcornButton();
        }

        [Then(@"the basket should display six items")]
        public void ThenTheBasketShouldDisplaySixItems()
        {
            Assert.That(orderPage.IsItemInTheBasketDisplayed);
        }

    }
}
