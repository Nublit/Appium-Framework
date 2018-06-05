using NUnit.Framework;
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

