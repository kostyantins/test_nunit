using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace TestProject.utils
{
    public class GetInstance
    {
        private static IWebDriver driver;

        public static IWebDriver Driver()
        {
            if (driver == null)
            {
                driver = new FirefoxDriver();
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