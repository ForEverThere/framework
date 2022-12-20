using NUnit.Framework;

namespace GitHubAutomation
{
    [TestFixture]
    public class AmericanAirwaysTests
    {
        private Steps.Steps steps = new Steps.Steps();

        [SetUp]
        public void Init()
        {
            steps.InitBrowser();
        }

        [TearDown]
        public void Cleanup()
        {
            steps.CloseBrowser();
        }

        [Test]
        public void Test1()
        {
            steps.LocalizationPage();
        }

        [Test]
        public void Test2()
        {
            steps.FindFlightMain();
            steps.FindFlightDownload();
        }

        [Test]
        public void Test3()
        {
            steps.SearchBenefitsMain();
            steps.SearchBenefitsSearch();
        }

        [Test]
        public void Test4()
        {
            steps.Requirements();
        }

        [Test]
        public void Test5()
        {
            steps.InformationMain();
            steps.InformationBag();
        }

        [Test]
        public void Test6()
        {
            steps.CarClick();
        }

        [Test]
        public void Test7()
        {
            steps.MainPhoneClick();
            steps.PhoneClick();
        }

        [Test]
        public void Test8()
        {
            steps.Advantage();
            steps.AdvantageStep();
        }

        [Test]
        public void Test9()
        {
            steps.Confidence();
            steps.ConfidencePage();
        }

        [Test]
        public void Test10()
        {
            steps.PauseSliderTime();
        }
    }
}
