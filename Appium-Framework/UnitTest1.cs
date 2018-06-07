using AppiumFramework;
using AppiumFramework.HomePage;
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
            homePage.ClickNumber8();
        }
    }
}