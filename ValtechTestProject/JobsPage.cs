using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechTestProject
{
    class JobsPage
    {
        //Constructor
        public JobsPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h1[text()='Jobs']")]
        public IWebElement jobsHeader;

        [FindsBy(How = How.CssSelector, Using = "[data-icon='earth-contact']")]
        public IWebElement earthButton;
            
    }
}
