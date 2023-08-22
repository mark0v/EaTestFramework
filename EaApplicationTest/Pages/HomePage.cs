using EaFramework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaApplicationTest.Pages
{
    public class HomePage
    {
        private readonly IDriverFixture _driverFixture;

        public HomePage(IDriverFixture driverFixture) 
        {
            _driverFixture = driverFixture;
        }

        private IWebElement lnkHome => _driverFixture.Driver.FindElement(By.LinkText("Home"));
        private IWebElement lnkPrivacy => _driverFixture.Driver.FindElement(By.LinkText("Privacy"));
        private IWebElement lnkProduct => _driverFixture.Driver.FindElement(By.LinkText("Product"));

        public void ClickProduct() => lnkProduct.Click();

    }
}
