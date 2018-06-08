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
        public virtual By Number1Button => By.Id("number1");

        public virtual By Number2Button => By.Id("number2");

        public virtual By Number3Button => By.Id("number3");

        public virtual By Number4Button => By.Id("number4");

        public virtual By Number5Button => By.Id("number5");

        public virtual By Number6Button => By.Id("number6");

        public virtual By Number7Button => By.Id("number7");

        public virtual By Number8Button => By.Id("number8");

        public virtual By Number9Button => By.Id("number9");

        public virtual By Number0Button => By.Id("number0");

        public virtual By NumberDivideButton => By.Id("divide");

        public virtual By NumberMultiplyButton => By.Id("multilpy");

        public virtual By NumberSubrtractButton => By.Id("subract");

        public virtual By NumberAdditionButton => By.Id("addition");

        public virtual By NumberCalculateButton => By.Id("calculate");

        public virtual By NumberClearButton => By.Id("clear");

        public virtual By ResultText => By.Id("results");
    }
}
