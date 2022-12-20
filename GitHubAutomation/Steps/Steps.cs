using System.Threading;
using GitHubAutomation.Pages;
using NUnit.Framework;
using OpenQA.Selenium;

namespace GitHubAutomation.Steps
{
    public class Steps
    {
        IWebDriver driver;

        public void InitBrowser()
        {
            driver = Driver.DriverInstance.GetInstance();
        }

        public void CloseBrowser()
        {
            Driver.DriverInstance.CloseBrowser();
        }

        public void LocalizationPage()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.Localization();
            Assert.AreEqual("https://www.americanairlines.fr/intl/fr/index.jsp", driver.Url);
        }

        public void FindFlightMain()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.InsertData();
        }

        public void FindFlightDownload()
        {
            DownLoadPage _downLoadPage = new DownLoadPage(driver);
            _downLoadPage.Clicks();
            Assert.AreEqual("Passengers",driver.FindElement(By.XPath("/html/body/main/div/form/h1")).Text);
        }

        public void SearchBenefitsMain()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.SearchBenefits();
        }

        public void SearchBenefitsSearch()
        {
            SearchPage _searchPage = new SearchPage(driver);
            _searchPage.SearchBenefits();
            Assert.AreEqual("https://www.aa.com/i18n/aadvantage-program/aadvantage-status/aadvantage-status-benefits.jsp", driver.Url);
        }

        public void Requirements()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.RequirementCheck();
            Assert.AreEqual("TSA won’t allow you to pass through security checkpoints at the airport if your ID doesn’t comply.", driver.FindElement(By.XPath("/html/body/div[5]/div/section[2]/section[7]/div/p[2]")).Text);
        }

        public void InformationMain()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.TravelInformation();
        }

        public void InformationBag()
        {
            BagPage _bagPage = new BagPage(driver);
            _bagPage.TravelInformationBags();
            Assert.AreEqual("https://www.aa.com/i18n/travel-info/baggage/checked-baggage-policy.jsp", driver.Url);
        }

        public void CarClickMain()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.CarsClick();
        }

        public void CarClick()
        {
            CarPage _carPage = new CarPage(driver);
            _carPage.OpenPage();
            _carPage.CarFind();
            Assert.AreEqual("https://www.aa.com/car?execution=e1s2", driver.Url);
        }

        public void MainPhoneClick()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.Phones();
        }

        public void PhoneClick()
        {
            PhonePage _phonePage = new PhonePage(driver);
            _phonePage.WiFi();
            Assert.AreEqual("https://www.aa.com/i18n/travel-info/experience/entertainment/wi-fi-and-connectivity.jsp",driver.Url);
        }

        public void Advantage()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.AdvantageMain();
        }

        public void AdvantageStep()
        {
            AdvantagePage _advantagePage = new AdvantagePage(driver);
            _advantagePage.Advantage();
            Assert.AreEqual("https://www.aa.com/i18n/aadvantage-program/aadvantage-status/aadvantage-status.jsp#statusqualification",driver.Url);
        }

        public void Confidence()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.Confident();
        }

        public void ConfidencePage()
        {
            TravelInfoPage _travelInfoPage = new TravelInfoPage(driver);
            _travelInfoPage.Travel();
            Assert.AreEqual("https://www.aa.com/i18n/travel-info/covid-19-testing.jsp#verifly",driver.Url);
        }

        public void PauseSliderTime()
        {
            MainPage _mainPage = new MainPage(driver);
            _mainPage.OpenPage();
            _mainPage.Pause();
            var beginning = driver.FindElement(By.XPath("/html/body/main/div/div[1]/div[1]/div[2]/a/img")).Text;
            Thread.Sleep(10000);
            var ending = driver.FindElement(By.XPath("/html/body/main/div/div[1]/div[1]/div[2]/a/img")).Text;
            Assert.AreEqual(beginning, ending);
        }
    }
}
