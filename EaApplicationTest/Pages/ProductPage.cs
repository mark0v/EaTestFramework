using EaFramework.Driver;
using EaFramework.Extensions;
using OpenQA.Selenium;

namespace EaApplicationTest.Pages
{
    public class ProductPage
    {
        private readonly IDriverFixture _driverFixture;

        public ProductPage(IDriverFixture driverFixture)
        {
            _driverFixture = driverFixture;
        }

        private IWebElement txtName => _driverFixture.Driver.FindElement(By.Id("Name"));
        private IWebElement txtDescription => _driverFixture.Driver.FindElement(By.Id("Description"));
        private IWebElement txtPrice => _driverFixture.Driver.FindElement(By.Id("Price"));
        private IWebElement ddlProductType => _driverFixture.Driver.FindElement(By.Id("ProductType"));
        private IWebElement lnkCreate => _driverFixture.Driver.FindElement(By.LinkText("Create"));

        private IWebElement tbList => _driverFixture.Driver.FindElement(By.CssSelector(".table"));

        private IWebElement btnCreate => _driverFixture.Driver.FindElement(By.Id("Create"));

        public void ClickCreateButton() => lnkCreate.Click();

        public void CreateProduct(string name, string description, string price, string productType)
        {
            txtName.SendKeys(name);
            txtDescription.SendKeys(description);
            txtPrice.SendKeys(price);
            ddlProductType.SelectDropdownByText(productType);
            btnCreate.Click();
        }

        public void PerformClickOnSpecialValue(string name, string operation)
        {
            tbList.PerformActionOnCell("5", "Name", name, operation);
        }
    }
}
