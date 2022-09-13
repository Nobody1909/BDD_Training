using OpenQA.Selenium;
using SpecFlow_Automation.Hooks;
using System;
using TechTalk.SpecFlow;

namespace SpecFlow_Automation.StepDefinations
{
    [Binding]
    public class EmergencyContactsStepDefinitions
    {
        [When(@"I click on My Info")]
        public void WhenIClickOnMyInfo()
        {
            AutomationHooks.driver.FindElement(By.XPath("//div[@id='app']/div[1]/div[1]/aside[1]/nav[1]/div[2]/ul[1]/li[6]/a[1]")).Click();

        }

        [When(@"I click on Emergency Contacts")]
        public void WhenIClickOnEmergencyContacts()
        {
            
            AutomationHooks.driver.FindElement(By.XPath("(//div[@class='orangehrm-tabs-wrapper']//a)[3]")).Click();
        }

        [When(@"I click on Add")]
        public void WhenIClickOnAdd()
        {
            AutomationHooks.driver.FindElement(By.XPath("(//button[@type='button'])[2]")).Click();

        }

        [When(@"I fill the Add Emergency Contact section")]
        public void WhenIFillTheAddEmergencyContactSection(Table table)
        {
            String name = table.Rows[0]["Name"];
            String relationship = table.Rows[0]["Relationship"];
            String homeTelephone = table.Rows[0]["Home_Telephone"];
            String mobile = table.Rows[0]["Mobile"];
            String workTelephone = table.Rows[0]["Work_Telephone"];

            AutomationHooks.driver.FindElement(By.XPath("//label[text()='Name']/following::input")).SendKeys(name);
            AutomationHooks.driver.FindElement(By.XPath("(//span[text()='Configuration ']/following::input)[2]")).SendKeys(relationship);
            AutomationHooks.driver.FindElement(By.XPath("//input[@modelmodifiers='[object Object]']")).SendKeys(homeTelephone);
            AutomationHooks.driver.FindElement(By.XPath("(//input[@modelmodifiers='[object Object]'])[2]")).SendKeys(mobile);
            AutomationHooks.driver.FindElement(By.XPath("(//input[@modelmodifiers='[object Object]'])[3]")).SendKeys(workTelephone);        

        }

        [When(@"I click on Save")]
        public void WhenIClickOnSave()
        {
            AutomationHooks.driver.FindElement(By.XPath("(//button[contains(@class,'oxd-button oxd-button--medium')])[2]")).Click();
        }

        [Then(@"I verify the added name")]
        public void ThenIVerifyTheAddedName()
        {

           //String nameValue =  AutomationHooks.driver.FindElement(By.XPath("(//div[@class='oxd-table-cell oxd-padding-cell']//div)[3]")).GetAttribute();

        }


    }
}
