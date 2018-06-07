using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework.AbstractDriverProduct
{
    public class iOSDriver : Driver
    {
        public iOSDriver()
        {
            DesiredCapabilities desiredCapabilities = null;
            string standAloneServerURI = null;
            TimeSpan serverWait;
            TimeSpan wait;

            var driver = new IOSDriver<AppiumWebElement>
            (
                new Uri(standAloneServerURI),
                 desiredCapabilities,
                serverWait
            );

            driver.Manage().Timeouts().ImplicitlyWait(wait);
        }
    }
}
