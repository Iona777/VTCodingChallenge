using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;


namespace ValtechTestProject
{
    [TestClass]
    public class Test1
    {
        
        [TestInitialize]
        public void SetUp()
        {
            Driver.OpenBrowser("chrome");
        }

        [TestMethod]
        public void TestMethod1()
        {

            //Setup Pages
            HomePage     theHomePage;
            CasesPage    theCasesPage;
            ServicesPage theServicesPage;
            JobsPage     theJobsPage;
            ContactsPage theContactsPage;
            
            theHomePage     = new HomePage(Driver.driver);
            theCasesPage    = new CasesPage(Driver.driver);
            theServicesPage = new ServicesPage(Driver.driver);
            theJobsPage     = new JobsPage(Driver.driver);
            theContactsPage = new ContactsPage(Driver.driver);

            Driver.navigateTo("https://www.valtech.com");
            //Should not really need this as the waitForElement 
            //should (and normally does) wait for page to load.
            //However, there is an intermittent failure here.
            //It seems to happen first time test is run, and gets
            //less frequent on subsequent runs. This pause seems
            //to help reduce this frequency
            Driver.pause(5000); 
            Driver.waitForElement(theHomePage.latestNewsHeader);
            Assert.IsTrue(theHomePage.latestNewsHeader.Displayed);
            Driver.clickOn(theHomePage.burgerButton);
            Driver.pause(3000);
            Driver.clickOn(theHomePage.casesLink);
          
            Driver.waitForElement(theCasesPage.casesHeader);
            Assert.IsTrue(theCasesPage.casesHeader.Displayed);
            Driver.pause(3000);
            Driver.clickOn(theCasesPage.burgerButton);
            Driver.clickOn(theCasesPage.servicesLink);

            Driver.waitForElement(theServicesPage.ServicesHeader);
            Assert.IsTrue(theServicesPage.ServicesHeader.Displayed);
            Driver.pause(3000);
            Driver.clickOn(theServicesPage.burgerButton);
            Driver.clickOn(theServicesPage.jobsLink);

            Driver.waitForElement(theJobsPage.jobsHeader);
            Assert.IsTrue(theJobsPage.jobsHeader.Displayed);
            Driver.pause(3000);
            Driver.clickOn(theJobsPage.earthButton);

            Driver.waitForElement(theContactsPage.contactHeader);
            Driver.pause(3000);

            int numberOfOffices = theContactsPage.contactUsList.Count;

            Console.WriteLine("Number of Valtech offices = " + numberOfOffices);
            Debug.WriteLine  ("Number of Valtech offices = " + numberOfOffices);



            //Notes on the code:
            //The pause is included for the sake of the user to see page loaded
            //The assert is actually redundant here since test will fail if wait times out
            //only included as an assert was requested
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.quit();
        }
    }
}
