using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework.HomePage
{
    public interface IHomePage
    {
        By Number1Button { get; }

        By Number2Button { get; }

        By Number3Button { get; }

        By Number4Button { get; }

        By Number5Button { get; }

        By Number6Button { get; }

        By Number7Button { get; }

        By Number8Button { get; }

        By Number9Button { get; }

        By Number0Button { get; }

        By NumberDivideButton { get; }

        By NumberMultiplyButton { get; }

        By NumberSubrtractButton { get; }

        By NumberAdditionButton { get; }

        By NumberCalculateButton { get; }

        By NumberClearButton { get; }

        By ResultText { get; }
    }
}
