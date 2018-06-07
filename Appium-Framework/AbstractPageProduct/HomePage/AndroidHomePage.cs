using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework.HomePage
{
    /// <summary>
    /// Elements with specific functionality to Android 6 Marshmallow
    /// </summary>
    public class Android6MarshmallowHomePage : AbstractHomePage, IHomePage
    {
        public override By Number8Button => By.Id("number9");
    }
}
