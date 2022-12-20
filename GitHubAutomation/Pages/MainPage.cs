using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Pages
{
    public class MainPage
    {

        private IWebDriver _driver;
        private string BASE_URL= "https://www.aa.com/";
        private IWebElement _tripType => _driver.FindElement(By.XPath("/html/body/main/div/div[2]/div[1]/div/div/div/div[1]/form/div[2]/div[1]/div[2]/label/span[1]"));
        private IWebElement _fromField => _driver.FindElement(By.XPath("/html/body/main/div/div[2]/div[1]/div/div/div/div[1]/form/div[3]/div[1]/div/label/input"));
        private IWebElement _fromList => _driver.FindElement(By.XPath("/html/body/ul[1]/li/a"));
        private IWebElement _toField => _driver.FindElement(By.XPath("/html/body/main/div/div[2]/div[1]/div/div/div/div[1]/form/div[3]/div[2]/div/label/input"));
        private IWebElement _toList => _driver.FindElement(By.XPath("/html/body/ul[2]/li[1]/a"));
        private IWebElement _dateField => _driver.FindElement(By.XPath("/html/body/main/div/div[2]/div[1]/div/div/div/div[1]/form/div[4]/div[1]/div/label/input"));
        private IWebElement _searchButton => _driver.FindElement(By.XPath("/html/body/main/div/div[2]/div[1]/div/div/div/div[1]/form/div[4]/div[4]/div/input"));

    
        private IWebElement _dropDownMenu => _driver.FindElement(By.XPath("/html/body/header/div/div[1]/div/ul/li[6]/div[1]/a"));
        private IWebElement _countryMenu => _driver.FindElement(By.XPath("/html/body/header/div/div[1]/div/ul/li[6]/div[2]/form/label[1]/select"));
        private IWebElement _countryElement => _driver.FindElement(By.XPath("/html/body/header/div/div[1]/div/ul/li[6]/div[2]/form/label[1]/select/option[30]"));
        private IWebElement _languageMenu => _driver.FindElement(By.XPath("/html/body/header/div/div[1]/div/ul/li[6]/div[2]/form/label[2]/select"));
        private IWebElement _languageElement => _driver.FindElement(By.XPath("/html/body/header/div/div[1]/div/ul/li[6]/div[2]/form/label[2]/select/option[1]"));
        private IWebElement _selectLanguage => _driver.FindElement(By.XPath("/html/body/header/div/div[1]/div/ul/li[6]/div[2]/form/input[1]"));

        private IWebElement _searchField => _driver.FindElement(By.XPath("/html/body/header/div/div[1]/div/ul/li[7]/form/label/input"));
        private IWebElement _searchIcon => _driver.FindElement(By.XPath("/html/body/header/div/div[1]/div/ul/li[7]/form/button/span[1]"));
        
        private IWebElement _requirementUrl => _driver.FindElement(By.XPath("/html/body/main/div/div[2]/div[1]/div/div/div/div[1]/form/div[5]/div[1]/div/p[3]/a"));
        
        private IWebElement _travelInfo => _driver.FindElement(By.XPath("/html/body/header/div/div[2]/nav/ul/li[3]/button"));
        private IWebElement _travelInfoBags => _driver.FindElement(By.XPath("/html/body/header/div/div[2]/nav/ul/li[3]/div/ul[2]/li[1]/a"));

        private IWebElement _planTravel => _driver.FindElement(By.XPath("/html/body/header/div/div[2]/nav/ul/li[2]/button"));
        private IWebElement _planTravelCars => _driver.FindElement(By.XPath("/html/body/header/div/div[2]/nav/ul/li[2]/div/ul[1]/li[3]/a"));

        private IWebElement _travelMobile => _driver.FindElement(By.XPath("/html/body/header/div/div[2]/nav/ul/li[3]/div/ul[1]/li[3]/a"));

        private IWebElement _aAdvantage => _driver.FindElement(By.XPath("/html/body/header/div/div[2]/nav/ul/li[4]/button"));
        private IWebElement _aAdvantageMenu => _driver.FindElement(By.XPath("/html/body/header/div/div[2]/nav/ul/li[4]/div/ul[1]/li[1]/a"));

        private IWebElement _confidentTravel => _driver.FindElement(By.XPath("/html/body/main/div/div[2]/section[1]/div/div[1]/section/a"));

        private IWebElement _pauseSlider => _driver.FindElement(By.XPath("/html/body/main/div/div[1]/div[2]/button[3]"));
        
        public MainPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }
        public void OpenPage()
        {
            _driver.Navigate().GoToUrl(BASE_URL);
        }
        public void Localization()
        {
            var waitLong = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            waitLong.Until(_ => _dropDownMenu);
            _dropDownMenu.Click();
            _countryMenu.Click();
            _countryElement.Click();
            waitLong.Until(_ => _languageMenu);
            _languageMenu.Click();
            waitLong.Until(_ => _languageElement);
            _languageElement.Click();
            _selectLanguage.Click();
        }
        public void InsertData(string from = "Barcelona", string to = "Philadelphia", string date = "12/25/2022")
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            _tripType.Click();
            _fromField.SendKeys(from);
            wait.Until(_ => _fromList);
            _fromList.Click();
            _toField.SendKeys(to);
            wait.Until(_ => _toList);
            _toList.Click();
            _dateField.SendKeys(date);
            _searchButton.Click();
        }

        public void SearchBenefits(string str = "benefits")
        {
            _searchField.SendKeys(str);
            _searchIcon.Click();
        }

        public void RequirementCheck()
        {
            var waitLong = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));
            _requirementUrl.Click();
            waitLong.Until(_ => _driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/section[7]/div/p[2]")));
        }

        public void TravelInformation()
        {
            _travelInfo.Click();
            Thread.Sleep(1000);
            _travelInfoBags.Click();
        }

        public void CarsClick()
        {
            _planTravel.Click();
            Thread.Sleep(1000);
            _planTravelCars.Click();
        }

        public void Phones()
        {
            _travelInfo.Click();
            Thread.Sleep(1000);
            _travelMobile.Click();
        }

        public void AdvantageMain()
        {
            _aAdvantage.Click();
            Thread.Sleep(1000);
            _aAdvantageMenu.Click();
        }

        public void Confident()
        {
            _confidentTravel.Click();
        }

        public void Pause()
        {
            _pauseSlider.Click();
        }
    }
}
