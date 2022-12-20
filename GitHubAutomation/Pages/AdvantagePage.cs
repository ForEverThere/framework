using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Pages
{
    public class AdvantagePage
    {
        private IWebDriver _driver;
        private IWebElement _cardsClick => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/section[7]/div/div[2]/ul/li[2]/a"));
        public AdvantagePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }

        public void Advantage()
        {
            var waitLong = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            waitLong.Until(_ => _cardsClick);
            _cardsClick.Click();
            waitLong.Until(_ => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/h1")));
        }
    }
}