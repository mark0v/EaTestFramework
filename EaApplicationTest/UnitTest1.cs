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
            var testSettings = new TestSettings()
            {
                BrowserType = BrowserType.Chrome,
                ApplicationUrl = new Uri("http://localhost:8000/"),
                TimeoutInterval = 30
            };

            _drivingFixture = new DriverFixture(testSettings);
        }

        [Fact]
        public void Test1()
        {
            _drivingFixture.Driver.FindElement(By.LinkText("Product")).Click();
            _drivingFixture.Driver.FindElement(By.LinkText("Create")).Click();
        }

        public void Dispose()
        {
            _drivingFixture.Driver.Quit();
        }
    }
}