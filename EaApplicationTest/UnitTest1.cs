using AutoFixture.Xunit2;
using EaApplicationTest.Models;
using EaApplicationTest.Pages;
using EaFramework.Config;
using EaFramework.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using static EaFramework.Driver.DriverFixture;

namespace EaApplicationTest
{
    public class UnitTest1 : IDisposable
    {
        
        public IDriverFixture _drivingFixture;

        public UnitTest1() 
        {
            //var testSettings = new TestSettings()
            //{
            //    BrowserType = BrowserType.Chrome,
            //    ApplicationUrl = new Uri("http://localhost:8000/"),
            //    TimeoutInterval = 30
            //};

            var testsettings = 

            _drivingFixture = new DriverFixture(testSettings);
        }
        
        [Theory]
        [AutoData]
        public void Test2(Product product)
        {
            //HomePage
            var homePage = new HomePage(_drivingFixture);
            var productPage = new ProductPage(_drivingFixture);

            //Click the create link
            homePage.ClickProduct();

            //Create product
            productPage.ClickCreateButton();
            productPage.CreateProduct(product);

            productPage.PerformClickOnSpecialValue(product.Name, "Edit");

        }

        public void Dispose()
        {
            _drivingFixture.Driver.Quit();
        }
    }
}