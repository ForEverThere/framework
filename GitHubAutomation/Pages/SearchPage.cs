using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Pages
{
    public class SearchPage
    {
        private IWebDriver _driver;
        private IWebElement _statusBenefits => _driver.FindElement(By.XPath("/html/body/main/div/section[2]/div/div[2]/div[2]/ul/li[1]/a/h2"));
        public SearchPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void SearchBenefits()
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(60));
            wait.Until(_ => _statusBenefits);
            _statusBenefits.Click();
            wait.Until(_ => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/section[2]/h2")));
        }
    }
}