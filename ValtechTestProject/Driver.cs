using System;
using System.Threading;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;




namespace ValtechTestProject
{
    public static class Driver
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
                    Debug.Print("unknown browser");
                    break;
            }
        }

        public static void navigateTo(string target)
        {
            driver.Navigate().GoToUrl(target);
        }

        public static void waitForElement(IWebElement element)
        {
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        
        public static void pause(int time)
        {
            Thread.Sleep(time);
        }

        public static void clickOn(IWebElement element)
        {
            WaitForElement(element);
            //wait.Until(ExpectedConditions.ElementToBeClickable(element)).Click();
            element.Click();
        }

        public static void scrollDown()
        {
            IJavaScriptExecutor jse = (IJavaScriptExecutor)driver;
            jse.ExecuteScript("window.scrollBy(0,250)", "");
        }

        public static void WaitForElement(IWebElement element)
        {
            //Been getting some stales element references, so use this code to handle it.
            
                    wait.Until(ExpectedConditions.ElementToBeClickable(element));
            
        }


        public static void quit()
        {
            driver.Quit();
        }
    }
}
