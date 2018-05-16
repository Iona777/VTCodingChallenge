using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace VTCodingChallenge.Pages
{
    class MenuPage
    {
        //Constructor
        public MenuPage(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "[href='/about/']")]
        public IWebElement aboutLink;

        [FindsBy(How = How.CssSelector, Using = "[href='/services/']")]
        public IWebElement servicesLink;

        [FindsBy(How = How.CssSelector, Using = "[href='/work/']")]
        public IWebElement workLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='CTA-form-trigger']/div/div/span")]
        public IWebElement contactLink;

        [FindsBy(How = How.XPath, Using = "//*[@id='footer']/div/div[2]/p[2]")]
        public IWebElement officeList;

        

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


        public void clickOnContactsLink()
        {
            Driver.clickOn(contactLink);
        }

        public int getNumberofOffices()
        {
            string offices = officeList.Text;
            string[] split = offices.Split(',');
            int numberOfOffices = split.Count();
            //Since there is a comma after the last office
            numberOfOffices = numberOfOffices - 1;
            
            return numberOfOffices;
        }
    }
}
