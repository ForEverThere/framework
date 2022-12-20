using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Pages
{
    public class TravelInfoPage
    {
        private IWebDriver _driver;
        private IWebElement _veriFly => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/section[1]/div[2]/div[2]/ul[2]/li[2]/a"));
        public TravelInfoPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Travel()
        {
            var waitLong = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            waitLong.Until(_ => _veriFly);
            _veriFly.Click();
            waitLong.Until(_ => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/h1")));
        }
    }
}