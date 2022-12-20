using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Pages
{
    public class PhonePage
    {
        private IWebDriver _driver;
        private IWebElement _wiFi => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/nav/ul/li[2]/a"));
        public PhonePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        
        public void WiFi()
        {
            var waitLong = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            waitLong.Until(_ => _wiFi);
            _wiFi.Click();
            waitLong.Until(_ => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/section[1]/h2")));
        }
    }
}