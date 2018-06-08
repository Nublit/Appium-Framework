using AppiumFramework.AbstractPageProduct;
using OpenQA.Selenium;
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

        public void ClickButton(Buttons button)
        {
            _driver.FindElement(GetButton(button)).Click();
        }

        public string GetResult() => _driver.FindElement(_homePage.ResultText).Text;

        private By GetButton(Buttons button)
        {
            switch (button)
            {
                case Buttons.one:
                    return _homePage.Number1Button;
                case Buttons.two:
                    return _homePage.Number2Button;
                case Buttons.three:
                    return _homePage.Number3Button;
                case Buttons.four:
                    return _homePage.Number4Button;
                case Buttons.five:
                    return _homePage.Number5Button;
                case Buttons.six:
                    return _homePage.Number6Button;
                case Buttons.seven:
                    return _homePage.Number7Button;
                case Buttons.eight:
                    return _homePage.Number8Button;
                case Buttons.nine:
                    return _homePage.Number9Button;
                case Buttons.zero:
                    return _homePage.Number0Button;
                case Buttons.add:
                    return _homePage.NumberAdditionButton;
                case Buttons.subtract:
                    return _homePage.NumberSubrtractButton;
                case Buttons.multiply:
                    return _homePage.NumberMultiplyButton;
                case Buttons.divide:
                    return _homePage.NumberDivideButton;
                case Buttons.calculate:
                    return _homePage.NumberCalculateButton;
                case Buttons.clear:
                    return _homePage.NumberClearButton;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
