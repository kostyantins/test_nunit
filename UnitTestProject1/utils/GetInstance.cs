using System.Runtime.CompilerServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager.Helpers;

namespace TestProject.utils
{
    public class GetInstance
    {
        private static IWebDriver _driver;
        
        public static IWebDriver Driver()
        {
            if (_driver == null)
            {
                //new ChromeConfig();
                //new EdgeConfig();
                //new FirefoxConfig();
                //new InternetExplorerConfig();
                //new OperaConfig();
                //new PhantomConfig();

                //new DriverManager().SetUpDriver(new ChromeConfig(), "2.25");
                //new DriverManager().SetUpDriver(new ChromeConfig(), "Latest", Architecture.X32);
                //new DriverManager().SetUpDriver(new ChromeConfig(), "2.25", Architecture.X64);

                new DriverManager().SetUpDriver(new FirefoxConfig());

                _driver = new FirefoxDriver();
            }

            return _driver;
        }

        public static void DriverClose()
        {
            if (_driver != null)
            {
                _driver.Close();
                _driver.Quit();
            }

        }
    }
}