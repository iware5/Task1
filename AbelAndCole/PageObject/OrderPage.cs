using AbelAndCole.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbelAndCole.PageObject
{
    class OrderPage
    {
        public OrderPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement basket => driver.FindElement(By.XPath("//*[@id='BasketCount']"));





        public bool IsItemInTheBasketDisplayed()
        {
            return basket.Displayed;
        }










    }
}
