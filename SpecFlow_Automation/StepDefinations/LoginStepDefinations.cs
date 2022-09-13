using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlow_Automation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_Automation
{
    [Binding]
    public class LoginStepDefinitions
    {
       
        [Given(@"I have browser with orangehrm page")]
        public void GivenIHaveBrowserWithOrangehrmPage()
        {
           // Console.WriteLine("orangehrm page");
            AutomationHooks.driver = new ChromeDriver();
            AutomationHooks.driver.Manage().Window.Maximize();
            AutomationHooks.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            AutomationHooks.driver.Url = "https://opensource-demo.orangehrmlive.com/";

        }

        [When(@"I provide username as '([^']*)'")]
        public void WhenIProvideUsernameAs(string username)
        {
            AutomationHooks.driver.FindElement(By.XPath("//label[text()='Username']/following::input")).SendKeys(username);
        }

        [When(@"I provide password as '([^']*)'")]
        public void WhenIProvidePasswordAs(string password)
        {
            AutomationHooks.driver.FindElement(By.XPath("//label[text()='Password']/following::input")).SendKeys(password);
        }

        [When(@"I Click on login")]
        public void WhenIClickOnLogin()
        {
            //Console.WriteLine("Click on login");
            AutomationHooks.driver.FindElement(By.CssSelector("button[Type=submit]")).Click();
        }

        [Then(@"I should navigate to '([^']*)' dashboard screen")]
        public void ThenIShouldNavigateToDashboardScreen(string pIM)
        {
            Console.WriteLine(pIM);
        }

        [Then(@"I should get error message as '([^']*)'")]
        public void ThenIShouldGetErrorMessageAs(string expectedError)
        {
            //Console.WriteLine(expectedError);
            String actualError = AutomationHooks.driver.FindElement(By.CssSelector(".oxd-alert-content-text")).Text;
            Assert.Equal(expectedError, actualError);
        }

    }
}
