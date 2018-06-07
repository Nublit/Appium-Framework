using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework.AbstractDriverProduct
{
    public abstract class Driver
    {
        public AppiumDriver<AppiumWebElement> appiumDriver;
    }
}
