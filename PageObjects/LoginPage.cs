using OpenQA.Selenium;

namespace SeleniumTestFramework
{
    public class LoginPage
    {
        IWebDriver _webDriver;

        public LoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void EnterEmail(string email)
        {
            IWebElement emailElement = _webDriver.FindElement(By.Id("email"));
            emailElement.Clear();
            emailElement.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            IWebElement passwordElement = _webDriver.FindElement(By.Id("password"));
            passwordElement.Clear();
            passwordElement.SendKeys(password);
        }

        public void ClickSignInButton()
        {
            _webDriver.FindElement(By.Id("SubmitLogin")).Click();
        }

        public void SignIn(User user)
        {
            EnterEmail(user.Email);
            EnterPassword(user.Password);
            ClickSignInButton();
        }
    }
}