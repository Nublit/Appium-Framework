using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework.AbstractDriverProduct
{
    public class AndroidDriver : Driver
    {
        public AndroidDriver()
        {
            DesiredCapabilities desiredCapabilities = new DesiredCapabilities();
            desiredCapabilities.SetCapability("udid", "7DHEBQTWDATK65IB");
            desiredCapabilities.SetCapability("platformName", "Android");
            desiredCapabilities.SetCapability("platformName", "Android");
            desiredCapabilities.SetCapability("deviceName", "Real_JPBlue");
            desiredCapabilities.SetCapability("app", @"C:\git\test.apk");

            string standAloneServerURI = "http://localhost:4444/wd/hub";
            TimeSpan serverWait = TimeSpan.FromSeconds(Int32.Parse("1200"));
            TimeSpan wait = TimeSpan.FromSeconds(Int32.Parse("60"));

            appiumDriver = new AndroidDriver<AppiumWebElement>
            (
                new Uri(standAloneServerURI),
                desiredCapabilities,
                serverWait
            );

            appiumDriver.Manage().Timeouts().ImplicitlyWait(wait);
        }
    }
}
