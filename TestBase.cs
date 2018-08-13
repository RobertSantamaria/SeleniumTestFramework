using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestFramework
{
    public class TestBase
    {
        IWebDriver _webDriver;
        protected string Url => "http://automationpractice.com/index.php?controller=authentication&back=my-account";

        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl(Url);
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Close();
            _webDriver.Quit();
        }
    }
}