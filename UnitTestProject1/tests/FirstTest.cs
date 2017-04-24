using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using Assert = NUnit.Framework.Assert;

namespace TestProject
{
    [TestFixture]
    public class FirstTest
    {
        IWebDriver Driver = new FirefoxDriver();

        [SetUp]
        public void SetUp()
        {
            Driver.Url = "https://www.google.com";
        }

        [Test(Description = "Google test"), Category("smoke_test")]
        public void TestMethod1()
        {
            IWebElement element = Driver.FindElement(By.Id("hplogo"));

            Assert.That(element.Displayed);
        }

        [TearDown]
        public void TurnDown()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}