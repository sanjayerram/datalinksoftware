using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace SampleTest
{
    [TestClass]
    public class SwagLogin
    {
        [TestMethod]
        public void verifySwabLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
            driver.Manage().Window.Maximize();
            LoginPage login = new LoginPage(driver);
            login.TypeUsername();
            login.TypePassword();
            login.ClickonLoginButton();
            System.Threading.Thread.Sleep(5000);
            driver.Quit();

        }
    }
}
