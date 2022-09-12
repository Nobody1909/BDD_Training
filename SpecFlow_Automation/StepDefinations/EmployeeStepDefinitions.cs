using OpenQA.Selenium;
using SpecFlow_Automation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_Automation.StepDefinations
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        [When(@"I enter username as '([^']*)'")]
        public void WhenIEnterUsernameAs(string username)
        {
            AutomationHooks.driver.FindElement(By.Name("username")).SendKeys(username);
        }

        [When(@"I enter password as '([^']*)'")]
        public void WhenIEnterPasswordAs(string p0)
        {
            AutomationHooks.driver.FindElement(By.Name("password")).SendKeys(p0);
        }

        [When(@"I click on login")]
        public void WhenIClickOnLogin()
        {
            AutomationHooks.driver.FindElement(By.CssSelector("button[Type=submit]")).Click();
        }

        [When(@"I click on PIM")]
        public void WhenIClickOnPIM()
        {
            AutomationHooks.driver.FindElement(By.XPath("(//span[contains(@class,'oxd-text oxd-text--span')])[2]")).Click();
        }

        [When(@"I click on Add Employee")]
        public void WhenIClickOnAddEmployee()
        {
            AutomationHooks.driver.FindElement(By.XPath("//a[text()='Add Employee']")).Click();
        }

        [When(@"I fill the Add employee section")]
        public void WhenIFillTheAddEmployeeSection(Table table)
        {
            String fName = table.Rows[0]["firstname"];
            String mName = table.Rows[0]["middlename"];
            String lName = table.Rows[0]["lastname"];
            String empId = table.Rows[0]["employee_id"];
            String toggleLoginDetail = table.Rows[0]["toggle_login_detail"];
            String userName = table.Rows[0]["username"];
            String password = table.Rows[0]["password"];
            String confirmPassword = table.Rows[0]["confirm_password"];
            String status = table.Rows[0]["status"];
            //AutomationHooks.driver.FindElement(By.XPath("//label[text()='Employee Id']/following::input")).Clear();
            // AutomationHooks.driver.FindElement(By.XPath("//label[text()='Employee Id']/following::input")).SendKeys(empId);
            AutomationHooks.driver.FindElement(By.Name("firstName")).SendKeys(fName);
            AutomationHooks.driver.FindElement(By.Name("middleName")).SendKeys(mName);
            AutomationHooks.driver.FindElement(By.Name("lastName")).SendKeys(lName);
           

            if (toggleLoginDetail.Equals("on"))
            {
                AutomationHooks.driver.FindElement(By.XPath("//input[@type='checkbox']/following-sibling::span[1]")).Click();
                AutomationHooks.driver.FindElement(By.XPath("//label[text()='Username']/following::input")).SendKeys(userName);
                AutomationHooks.driver.FindElement(By.XPath("//label[text()='Password']/following::input")).SendKeys(password);
                AutomationHooks.driver.FindElement(By.XPath("(//input[@type='password'])[2]")).SendKeys(confirmPassword);
                if (status.Equals("disabled"))
                {
                    AutomationHooks.driver.FindElement(By.XPath("(//input[@type='radio']/following-sibling::span)[2]")).Click();

                }
            }
           
        }

        [When(@"I click on save employee")]
        public void WhenIClickOnSaveEmployee()
        {
            AutomationHooks.driver.FindElement(By.XPath("(//button[contains(@class,'oxd-button oxd-button--medium')])[2]")).Click();
        }

        [Then(@"I should be navigated to personal details section with added employee records")]
        public void ThenIShouldBeNavigatedToPersonalDetailsSectionWithAddedEmployeeRecords()
        {

        }
    }
}
