using System;
using System.Collections.Generic;
using System.Text;
using AppiumFramework.HomePage;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;

namespace AppiumFramework
{
    class DriverFactory : AbstractDriverFactory
    {
        public override AbstractDriverProduct.AndroidDriver CreateAndroidDriver()
        {
            return new AbstractDriverProduct.AndroidDriver();
        }

        public override AbstractDriverProduct.iOSDriver CreateiOSDriver()
        {
            return new AbstractDriverProduct.iOSDriver();
        }
    }
}
