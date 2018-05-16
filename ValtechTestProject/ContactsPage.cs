using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechTestProject
{
    class ContactsPage
    {
        //Constructor
        public ContactsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "contactheader")]
        public IWebElement contactHeader;

        [FindsBy(How = How.XPath, Using = "//a[contains(@href,'contact-us')]")]
        public IList<IWebElement> contactUsList;

        [FindsBy(How = How.CssSelector, Using = "[data-icon='earth-contact']")]
        public IWebElement earthButton;
            
    }
}
