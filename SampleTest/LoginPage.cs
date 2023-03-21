using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SampleTest
{
   public class LoginPage
    {
        IWebDriver driver;
        By Username = By.Id("user-name");
        By Password = By.Id("password");
        By login_button = By.Id("login-button");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUsername()
        {
            driver.FindElement(Username).SendKeys("sanjay");
        }

        public void TypePassword()
        {
            driver.FindElement(Password).SendKeys("password@123");
        }
        public void ClickonLoginButton()
        {
            driver.FindElement(login_button).Click();
        }

    }
}
