﻿using EaFramework.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaApplicationTest.Pages
{
    public interface IHomePage
    {
        void ClickProduct();
    }

    public class HomePage : IHomePage
    {
        private readonly IDriverWait _driver;

        public HomePage(IDriverWait driver) 
        {
            _driver = driver;
        }

        private IWebElement lnkHome => _driver.FindElement(By.LinkText("Home"));
        private IWebElement lnkPrivacy => _driver.FindElement(By.LinkText("Privacy"));
        private IWebElement lnkProduct => _driver.FindElement(By.LinkText("Product"));

        public void ClickProduct() => lnkProduct.Click();

    }
}
