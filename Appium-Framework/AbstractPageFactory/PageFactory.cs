using System;
using System.Collections.Generic;
using System.Text;
using AppiumFramework.HomePage;
using AppiumFramework.Login;

namespace AppiumFramework.AbstractPageFactory
{
    public class PageFactory : AbstractPageFactory
    {
        public override AndroidHomePage CreateAndroidHomePage()
        {
            return new AndroidHomePage();
        }

        public override AndroidLogin CreateAndroidLogin()
        {
            throw new NotImplementedException();
        }

        public override HomePage.IOSHomePage CreateiOSHomePage()
        {
            throw new NotImplementedException();
        }

        public override iOSLogin CreateiOSLogin()
        {
            throw new NotImplementedException();
        }
    }
}
