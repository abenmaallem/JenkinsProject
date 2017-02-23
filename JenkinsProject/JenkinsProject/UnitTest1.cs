using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace JenkinsProject
{
    class UnitTest1
    {
        IWebDriver _driver;
        HomePage _homePage;

        [SetUp]
        public void TestFirefox()
        {
            _homePage = new HomePage();
            _driver = new FirefoxDriver();
            _driver.Navigate().GoToUrl("http://www.seloger.com");
        }

        //[TearDown]
        //public void ApresLeTest()
        //{
        //    _driver.Quit();
        //}

        [Test]
        public void TestMethod1()
        {
            _homePage.Louer(_driver).Click();
            //ok
            _homePage.SaisieVille(_driver).Clear();
            _homePage.SaisieVille(_driver).SendKeys("Paris");
            _homePage.BudgetMax(_driver).Clear();
            _homePage.BudgetMax(_driver).SendKeys("700");
            //_homePage.Rechercher(_driver).Click();
        }
    }
}
