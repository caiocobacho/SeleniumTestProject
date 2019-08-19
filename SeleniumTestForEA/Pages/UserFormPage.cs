using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumTestForEA.Pages
{
    class UserFormPage
    {


        private IWebDriver _driver;

        public UserFormPage(IWebDriver driver)
        {
            _driver = driver;

        }

        public IWebElement txtInicial => _driver.FindElement(By.Id("Initial"));
        public IWebElement txtFirstName => _driver.FindElement(By.Id("FirstName"));
        public IWebElement txtMiddleName => _driver.FindElement(By.Id("MiddleName"));
        public IWebElement txtLanguageEN => _driver.FindElement(By.Id("english"));


        public void EnterUserForm(string initial, string firstName, string middleName, string language) {
            txtInicial.SendKeys(initial);
            txtFirstName.SendKeys(firstName);
            txtMiddleName.SendKeys(middleName);
            txtLanguageEN.Click();
        }


    }
}
