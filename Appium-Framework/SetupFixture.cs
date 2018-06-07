using Autofac;
using NUnit.Framework;
using OpenQA.Selenium.Appium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework
{
    [SetUpFixture]
    public class SetupFixture
    {
        [ThreadStatic]
        public static IContainer Container;

        [ThreadStatic]
        public static AppiumDriver<AppiumWebElement> Driver;

        [ThreadStatic]
        public static ContainerBuilder containerBuilder;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            //Maybe spin up grid or something
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            //Maybe tear down grid
        }
    }
}

