using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace VTCodingChallenge.Pages
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

        [FindsBy(How = How.CssSelector, Using = "[data-icon='earth-contact']")]
        public IWebElement earthButton;

        [FindsBy(How = How.CssSelector, Using = "[data-icon='hamburger2']")]
        public IWebElement burgerButton;

        [FindsBy(How = How.CssSelector, Using = "[href='/about/']")]
        public IWebElement aboutLink;

        [FindsBy(How = How.CssSelector, Using = "[href='/services/']")]
        public IWebElement servicesLink;

        [FindsBy(How = How.CssSelector, Using = "[href='/work/']")]
        public IWebElement workLink;


        public void clickOnAboutLink()
        {
            Driver.clickOn(aboutLink);
        }

        public void clickOnServicesLink()
        {
            Driver.clickOn(servicesLink);
        }

        public void clickOnWorkLink()
        {
            Driver.clickOn(workLink);
        }
    }
}
