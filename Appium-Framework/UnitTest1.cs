using AppiumFramework;
using AppiumFramework.HomePage;
using FluentAssertions;
using NUnit.Framework;

namespace AppiumFFramework
{
    [TestFixture]
    public class SomeTest1 : TestBase
    {
        [Test]
        public void TestMethod1()
        {
            HomePage homePage = new HomePage(SetupFixture.Driver, SetupFixture.HomePage);
            homePage.ClickButton(AppiumFramework.AbstractPageProduct.Buttons.five);
            homePage.ClickButton(AppiumFramework.AbstractPageProduct.Buttons.multiply);
            homePage.ClickButton(AppiumFramework.AbstractPageProduct.Buttons.nine);
            homePage.ClickButton(AppiumFramework.AbstractPageProduct.Buttons.calculate);
            homePage.GetResult().Should().Be("45");
        }
    }
}