using AbelAndCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelAndCole.PageObject
{
    class LandingPage
    {
        public LandingPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement add => driver.FindElement(By.XPath("//*[@id='product-list']/li[1]/div[3]/div[3]/div[2]/div[1]"));
        IWebElement addhummus => driver.FindElement(By.XPath("//*[@id='product-list']/li[1]/div[3]/div[3]/div[2]/div[1]"));
        IWebElement plus => driver.FindElement(By.XPath("//*[@id='product-list']/li[1]/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement plushummus => driver.FindElement(By.XPath("//*[@id='product-list']/li[1]/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement addpopcorn => driver.FindElement(By.XPath("//*[@id='product-list']/li/div[3]/div[3]/div[2]/div[1]"));
        IWebElement pluspopcorn => driver.FindElement(By.XPath("//*[@id='product-list']/li/div[3]/div[3]/div[2]/div[2]/div/div[3]"));

        




        public void ClickOnAddButton()
        {
            add.Click();
        }

        public void ClickOnAddHummusButton()
        {
            addhummus.Click();
        }
        
        public void ClickOnPlusButton()
        {
            plus.Click();
        }

        public void ClickOnPlusHummusButton()
        {
            plushummus.Click();
        }

        public void ClickOnAddPopcorn()
        {
            addpopcorn.Click();
        }

        public void ClickOnPlusPopcornButton()
        {
            pluspopcorn.Click();
        }







    }
}
