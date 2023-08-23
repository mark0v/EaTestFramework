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
        
        private readonly IDriverFixture _driverFixture;
        private readonly IHomePage _homePage;
        private readonly IProductPage _productPage;

        public UnitTest1(IDriverFixture driverFixture, IHomePage homePage, IProductPage productPage) 
        {
            _driverFixture = driverFixture;                   
            _homePage = homePage;
            _productPage = productPage;
        }
        
        [Theory]
        [AutoData]
        public void Test2(Product product)
        {
            //Click the create link
            _homePage.ClickProduct();

            //Create product
            _productPage.ClickCreateButton();
            _productPage.CreateProduct(product);

            _productPage.PerformClickOnSpecialValue(product.Name, "Details");
            Thread.Sleep(3000);

        }

        public void Dispose()
        {
            _driverFixture.Driver.Quit();
        }
    }
}