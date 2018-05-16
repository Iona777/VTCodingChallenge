using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace VTCodingChallenge.Pages
{
    class AboutPage
    {
        //Constructor
        public AboutPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h1[text()='About']")]
        public IWebElement AboutHeader;

    }
}
