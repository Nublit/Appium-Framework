using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework.HomePage
{
    /// <summary>
    /// Methods for interacting with pages
    /// </summary>
    public class HomePage
    {
        AppiumDriver<AppiumWebElement> _driver;
        IHomePage _homePage;

        public HomePage(AppiumDriver<AppiumWebElement> driver, IHomePage homePage)
        {
            _driver = driver;
            _homePage = homePage;
        }

       public void ClickNumber8()
        {
            _driver.FindElement(_homePage.Number8Button).Click();
        }
    }
}
