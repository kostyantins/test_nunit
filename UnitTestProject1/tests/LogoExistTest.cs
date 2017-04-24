﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using TestProject.page_objects;
using TestProject.utils;
using static TestProject.utils.GetInstance;
using Assert = NUnit.Framework.Assert;

namespace TestProject
{
    public class LogoExistTest : TestRunner
    {
        [Test, Category("smoke_test"), Property("Priority", "High")]
        public void TestLogoExist()
        {
            Assert.That(Driver().FindElement(HomePage.Logo).Displayed);
        }
    }
}