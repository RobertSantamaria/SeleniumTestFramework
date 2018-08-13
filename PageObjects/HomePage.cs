using OpenQA.Selenium;

namespace SeleniumTestFramework
{
    public class HomePage
    {
        IWebDriver _webDriver;

        public HomePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }
    }
}