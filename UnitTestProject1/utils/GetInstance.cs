using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProject.utils
{
    public class GetInstance
    {
        private static IWebDriver driver;
        
        public static IWebDriver Driver()
        {
            if (driver == null)
            {
                new DriverManager().SetUpDriver(new ChromeConfig());

                driver = new ChromeDriver();
            }

            return driver;
        }

        public static void DriverClose()
        {
            if (driver != null)
            {
                driver.Close();
                driver.Quit();
            }

        }
    }
}