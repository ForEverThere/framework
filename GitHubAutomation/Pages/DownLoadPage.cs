using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Pages
{
    public class DownLoadPage
    {
        private string BASE_URL = "https://www.aa.com/booking/flights/choose-flights/flight1?bookingPathStateId=1671482735575-275&redirectSearchToLegacyAACom=false";
        private IWebDriver _driver;
        private IWebElement _clickFlight => _driver.FindElement(By.XPath("/html/body/main/div/section[2]/div[3]/ul/li[1]/div/div[2]/div/div[1]/button/div/div[2]"));
        private IWebElement _mainCabin => _driver.FindElement(By.XPath("/html/body/div[7]/div[1]/button"));
        private IWebElement _continueAsGuest => _driver.FindElement(By.XPath("/html/body/main/div/form/section[3]/button[1]"));
        public DownLoadPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public void Clicks()
        {
            var downloadPage = new DownLoadPage(_driver);
            var waitLong = new WebDriverWait(_driver, TimeSpan.FromSeconds(40));
            waitLong.Until((_ => downloadPage._clickFlight));
            downloadPage._clickFlight.Click();
            waitLong.Until((_ => downloadPage._mainCabin));
            downloadPage._mainCabin.Click();
            waitLong.Until((_ => downloadPage._continueAsGuest));
            downloadPage._continueAsGuest.Click();
            waitLong.Until((_ => _driver.FindElement(By.XPath("/html/body/main/div/form/h1"))));
        }
    }
}