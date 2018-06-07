using System;
using System.Collections.Generic;
using System.Text;

namespace AppiumFramework.AbstractPageFactory
{
    public abstract class AbstractPageFactory
    {
        public abstract HomePage.AndroidHomePage CreateAndroidHomePage();

        public abstract Login.AndroidLogin CreateAndroidLogin();

        public abstract HomePage.IOSHomePage CreateiOSHomePage();

        public abstract Login.iOSLogin CreateiOSLogin();
    }
}
