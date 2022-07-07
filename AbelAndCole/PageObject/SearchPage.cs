using AbelAndCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelAndCole.PageObject
{
    class SearchPage
    {
        public SearchPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement searchterm => driver.FindElement(By.XPath("//*[@id='search-term']"));
        IWebElement search => driver.FindElement(By.XPath("//*[@id='search-btn']"));
        IWebElement searchtermpopcorn => driver.FindElement(By.XPath("//*[@id='search-term']"));
        IWebElement searchbutton => driver.FindElement(By.XPath("//*[@id='search-btn']"));







        public void SearchItem(String Itemname)
        {
            searchterm.SendKeys(Itemname);
        }

        public void SearchButton()
        {
            search.Click();
        }

        public void SearchPopcorn(String Itemnamepopcorn)
        {
            searchtermpopcorn.SendKeys(Itemnamepopcorn);
        }

        public void PopcornSearchButton()
        {
            searchbutton.Click();
        }





    }
}
