using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;

namespace VTCodingChallenge
{
    class Driver
    {
        public static IWebDriver driver;
        public static WebDriverWait wait;


        public static void OpenBrowser(string selectedBrowser)
        {

            switch (selectedBrowser.ToLower())
            {
                case "chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    break;
                case "IE11":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    break;
                default:
                    Debug.Print("Unknown browser selected");
                    break;
            }


        }


        public static void navigateTo(string target)
        {
            driver.Navigate().GoToUrl(target);
        }

        public static void waitForElement(IWebElement element)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }


        public static void pause(int time)
        {
            Thread.Sleep(time);
        }

        public static void clickOn(IWebElement element)
        {
            waitForElement(element);
            element.Click();
        }

        public static void quit()
        {
            driver.Quit();
        }
    }
}
