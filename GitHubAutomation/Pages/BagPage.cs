using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Pages
{
    public class BagPage
    {
        private IWebDriver _driver;
        private IWebElement _checkedBags => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/nav/ul/li[2]/a"));
        public BagPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void TravelInformationBags()
        {
            var waitLong = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            waitLong.Until(_ => _checkedBags);
            _checkedBags.Click();
            waitLong.Until(_ => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/h1")));
        }
    }
}