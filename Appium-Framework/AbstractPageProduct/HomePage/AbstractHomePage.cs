using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework.HomePage
{
    /// <summary>
    /// Elements that have same property for finding them or same functionality for method
    /// </summary>
    public abstract class AbstractHomePage 
    {
        public virtual By Number8Button => By.Id("number8");
    }
}
