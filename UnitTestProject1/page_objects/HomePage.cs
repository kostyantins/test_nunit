using System;
using OpenQA.Selenium;

namespace TestProject.page_objects
{
    public class HomePage : AbstractPageObject
    {
        public static readonly By Logo = By.XPath("//*[@id='header']//a[@class='logo']");
        public static readonly String FirstHedderBaner = "(//*[@id='headerMenu']//a/span)[1]";
        public static readonly String SecondHedderBaner = "//*[@id='headerMenu']//a[@class='links-transition open-menu-link open-menu-link-style2 have-changed-marker']/span";
        public static readonly String ThreadHedderBaner = "//*[@id='headerMenu']//a[@class='links-transition open-menu-link has-slider']/span";
      
    }
}