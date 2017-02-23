using OpenQA.Selenium;
using System;

namespace JenkinsProject
{
    public class HomePage
    {

        public IWebElement Louer(IWebDriver _driver)
        {
            //_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            return _driver.FindElement(By.CssSelector(".c-quest-tabs > ul:nth-child(1) > li:nth-child(1) > a:nth-child(1)"));
        }

        public IWebElement SaisieVille(IWebDriver _driver)
        {
           // _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            return _driver.FindElement(By.CssSelector(".jsInlineContainer > input:nth-child(1)"));
        }

        public IWebElement BudgetMax(IWebDriver _driver)
        {
            //_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            return _driver.FindElement(By.CssSelector("label.textLabel:nth-child(3) > input:nth-child(1)"));
        }

        public IWebElement Rechercher(IWebDriver _driver)
        {
            //_driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(60));
            return _driver.FindElement(By.CssSelector("#i-quest-panel-2 > div:nth-child(2) > a:nth-child(1)"));
        }
        //ok
        
    }
}
