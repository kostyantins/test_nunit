using NUnit.Framework;
using OpenQA.Selenium;
using TestProject.utils;
using static TestProject.utils.GetInstance;

namespace TestProject
{
    [TestFixture]
    public class TextEqualsExelRiderTest : TestRunner
    {
        
        public class HederBanersTextEqualTest : TestRunner
        {
            [Test, TestCaseSource(typeof(DataProvider), nameof(DataProvider.TextEqualText))]
            public void TestHederBanersTextEqual(string text)
            {
                Assert.That("Vasya", Is.EqualTo(text));
            }
        }
    }
}