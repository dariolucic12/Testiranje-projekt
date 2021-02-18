using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class Calculator
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void SumOfNumbers()
        {
            driver.Navigate().GoToUrl("https://www.calculator.net/");
            driver.FindElement(By.XPath("//span[@onclick='r(2)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick='r(2)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick='r(2)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick=\"r('+')\"]")).Click();
            driver.FindElement(By.XPath("//span[@onclick='r(3)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick='r(3)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick=\"r('=')\"]")).Click();
        }
        [Test]
        public void DifferenceOfNumbers()
        {
            driver.Navigate().GoToUrl("https://www.calculator.net/");
            driver.FindElement(By.XPath("//span[@onclick='r(2)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick='r(2)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick='r(2)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick=\"r('-')\"]")).Click();
            driver.FindElement(By.XPath("//span[@onclick='r(5)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick='r(5)']")).Click();
            driver.FindElement(By.XPath("//span[@onclick=\"r('=')\"]")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
