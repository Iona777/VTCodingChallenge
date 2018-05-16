using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechTestProject
{
    class CasesPage
    {
        //Constructor
        public CasesPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h1[text()='Cases']")]
        public IWebElement casesHeader;

        [FindsBy(How = How.CssSelector, Using = "[data-icon='hamburger2']")]
        public IWebElement burgerButton;

        [FindsBy(How = How.CssSelector, Using = "[href='/services/']")]
        public IWebElement servicesLink;

    }
}
