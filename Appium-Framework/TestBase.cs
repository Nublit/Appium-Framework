using NUnit.Framework;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework
{
    public class TestBase
    {
        [SetUp]
        public void Setup()
        {
            var driverFactory = new DriverFactory();

            SetupFixture.Driver = driverFactory.CreateAndroidDriver().appiumDriver;
        }

        [TearDown]
        public void TearDown()
        {
            if (SetupFixture.Driver != null)
            {
                SetupFixture.Driver.Quit();
                SetupFixture.Driver = null;
            }
        }
    }
}

