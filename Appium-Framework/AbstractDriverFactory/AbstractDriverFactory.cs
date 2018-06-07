using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework
{
    public abstract class AbstractDriverFactory
    {
        public abstract AbstractDriverProduct.AndroidDriver CreateAndroidDriver();

        public abstract AbstractDriverProduct.iOSDriver CreateiOSDriver();
    }
}
