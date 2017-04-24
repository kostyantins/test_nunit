using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;
using TestProject.utils;
using static TestProject.page_objects.HomePage;
using static TestProject.utils.GetInstance;


namespace TestProject
{
    [TestFixture]
    public class HederBanersTextEqualmultiplyTest : TestRunner
    {
        [Test, Category("parent_test")]
        public void TestHederBanersTextEqualmultiply()
        {

            IWebElement firstElement = Driver().FindElement(By.XPath(FirstHedderBaner));
            IWebElement secondElement = Driver().FindElement(By.XPath(SecondHedderBaner));
            IWebElement thirdElement = Driver().FindElement(By.XPath(ThreadHedderBaner));

            Assert.Multiple(() =>
            {
                Assert.That("Explore Bukovel", Is.EqualTo(firstElement.Text).IgnoreCase, firstElement + " should be equal 'Explore Bukovel'");
                Assert.That("Planner", Is.EqualTo(secondElement.Text).IgnoreCase, secondElement + " should be equal 'Planner'");
                Assert.That("Specials", Is.EqualTo(thirdElement.Text).IgnoreCase, thirdElement + " should be equal 'Specials'");
            });
        }
    }
}