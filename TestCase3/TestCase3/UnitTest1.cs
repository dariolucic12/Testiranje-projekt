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
    public class Youtube
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
        public void TheYoutubeTest()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.FindElement(By.XPath("(//a[@id='endpoint']/paper-item/yt-formatted-string)[2]")).Click();
            driver.FindElement(By.XPath("(//a[@id='endpoint']/paper-item/yt-formatted-string)[3]")).Click();
            driver.FindElement(By.XPath("(//a[@id='endpoint']/paper-item/yt-formatted-string)[6]")).Click();
            driver.FindElement(By.XPath("(//a[@id='endpoint']/paper-item/yt-formatted-string)[7]")).Click();
            driver.FindElement(By.XPath("(//a[@id='endpoint']/paper-item/yt-formatted-string)[8]")).Click();
            driver.FindElement(By.XPath("(//a[@id='endpoint']/paper-item/yt-formatted-string)[9]")).Click();
            driver.FindElement(By.XPath("(//a[@id='endpoint']/paper-item/yt-formatted-string)[10]")).Click();
            driver.FindElement(By.XPath("(//a[@id='endpoint']/paper-item/yt-formatted-string)[11]")).Click();
            driver.FindElement(By.Name("search_query")).Click();
            driver.FindElement(By.Name("search_query")).Clear();
            driver.FindElement(By.Name("search_query")).SendKeys("movies");
            driver.FindElement(By.Id("search-form")).Submit();
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
