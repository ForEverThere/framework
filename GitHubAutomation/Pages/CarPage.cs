using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Pages
{
    public class CarPage
    {
        private IWebDriver _driver;
        private IWebElement _searchButton => _driver.FindElement(By.XPath("/html/body/div[2]/section/div/div[1]/div[2]/div[2]/div[1]/form/div[4]/div/button"));
        private IWebElement _picLocation => _driver.FindElement(By.XPath("/html/body/div[2]/section/div/div[1]/div[2]/div[2]/div[1]/form/div[1]/div[2]/label/input"));
        private IWebElement _pickLocation => _driver.FindElement(By.CssSelector(@"#carHomeSearchForm\.pickUpPlace"));
        private IWebElement _pickDate => _driver.FindElement(By.XPath("/html/body/div[2]/section/div/div[1]/div[2]/div[2]/div[1]/form/div[1]/div[5]/div[1]/div/label/input"));
        private IWebElement _dropDate => _driver.FindElement(By.XPath("/html/body/div[2]/section/div/div[1]/div[2]/div[2]/div[1]/form/div[1]/div[6]/div[1]/div/label/input"));
        public CarPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public void OpenPage()
        {
            _driver.Navigate().GoToUrl("https://www.aa.com/car?execution=e7s1");
        }
        public void CarFind(string location = "BCN", string pick = "12/25/2022", string drop = "12/26/2022")
        {
            var waitLong = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            waitLong.Until(_ => _pickLocation);
            _pickLocation.SendKeys(location);
            _pickDate.SendKeys(pick);
            _dropDate.SendKeys(drop);
            _searchButton.Click();
            waitLong.Until(_ => _driver.FindElement(By.XPath("/html/body/div[2]/section/form/div/div[2]/section/div[3]/div[2]/div[4]/div/div/div[3]/div[2]/button")));
        }
    }
}