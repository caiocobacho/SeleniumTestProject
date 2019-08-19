﻿using SeleniumTestForEA.Pages;
using System;
using TestProject.SDK;
using TestProject.SDK.Tests;
using TestProject.SDK.Tests.Helpers;

namespace SeleniumTestForEA
{
    public class SeleniumTest : IWebTest

    {
        public ExecutionResult Execute(WebTestHelper helper)
        {
            var driver = helper.Driver;

            //Navigate to the app

            driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/Login.html");

            //Login
            LoginPage loginPage = new LoginPage(driver);

            loginPage.PerformLogin("admin", "admin");

            return ExecutionResult.Passed;
        }
    }
}
