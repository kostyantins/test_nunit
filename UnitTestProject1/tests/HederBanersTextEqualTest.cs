using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TestProject.utils;
using TestProject.page_objects;
using static TestProject.utils.GetInstance;

namespace TestProject
{
    [TestFixture]
    public class HederBanersTextEqualTest : TestRunner
    {
        [Test, TestCaseSource(typeof(DataProvider), nameof(DataProvider.HederBlockText))]
        public void TestHederBanersTextEqual(string text, string locator)
        {
            Assert.That(text, Is.EqualTo(Driver().FindElement(By.XPath(locator)).Text).IgnoreCase);
        }
    }
}