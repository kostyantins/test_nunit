using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using TestProject.page_objects;
using TestProject.utils;
using static System.TimeSpan;
using static TestProject.utils.GetInstance;

namespace TestProject.utils
{
    public class TestRunner
    {
        protected HomePage HomePage;

        [TestFixtureSetUp]
        public void SetUp()
        {
           
            Driver().Url = "https://bukovel.com/en/";

            HomePage = new HomePage();
        }

        [TestFixtureTearDown]
        public void TurnDown()
        {
            Driver().Close();
            Driver().Quit();
        }
    }
}