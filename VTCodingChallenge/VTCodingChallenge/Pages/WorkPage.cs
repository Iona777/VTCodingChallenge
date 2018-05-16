using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace VTCodingChallenge.Pages
{
    class WorkPage
    {
        //Constructor
        public WorkPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.XPath, Using = "//h1[text()='Work']")]
        public IWebElement WorkHeader;

      

   
    }
}
