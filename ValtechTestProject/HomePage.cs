using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechTestProject
{
    class HomePage
    {
        //Constructor
        public HomePage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h2[text()='Latest news']")]
        public IWebElement latestNewsHeader;

        [FindsBy(How = How.CssSelector, Using = "[data-icon='hamburger2']")]
        public IWebElement burgerButton;

        [FindsBy(How = How.CssSelector, Using = "[href='/cases/']")]
        public IWebElement casesLink;

        


    }
}
