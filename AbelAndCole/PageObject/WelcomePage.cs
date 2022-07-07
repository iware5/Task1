using AbelAndCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelAndCole.PageObject
{
    class WelcomePage
    {
        public WelcomePage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement acceptcookies => driver.FindElement(By.XPath("//*[@id='ccc-notify-accept']"));
        IWebElement searchterm => driver.FindElement(By.XPath("//*[@id='search-term']"));
        IWebElement search => driver.FindElement(By.XPath("//*[@id='search-btn']"));





        public void NavigateToUrl(String Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        public void Accept()
        {
            acceptcookies.Click();
        }

        public void SearchItem(String Itemname)
        {
            searchterm.SendKeys(Itemname);
        }

        public void SearchButton()
        {
            search.Click();
        }








    }
}
