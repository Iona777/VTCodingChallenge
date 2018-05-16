using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VTCodingChallenge.Pages;

namespace VTCodingChallenge
{
    [TestClass]
    public class Test1
    {
        [TestInitialize]
        public void SetUp()
        {
            Driver.OpenBrowser("Chrome");
        }

        [TestMethod]
        public void TestMethod1()
        {

            //Setup Pages
            HomePage theHomePage;
            MenuPage theMenuPage;
            ServicesPage theServicesPage;
            AboutPage theAboutPage;
            WorkPage theWorkPage;
          
            

            theHomePage         = new HomePage(Driver.driver);
            theMenuPage         = new MenuPage(Driver.driver);
            theServicesPage     = new ServicesPage(Driver.driver);
            theAboutPage        = new AboutPage(Driver.driver);
            theWorkPage         = new WorkPage(Driver.driver);



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

            theMenuPage.clickOnAboutLink();
            Driver.waitForElement(theAboutPage.AboutHeader);
            Assert.IsTrue(theAboutPage.AboutHeader.Displayed);

            theMenuPage.clickOnServicesLink();
            Driver.waitForElement(theServicesPage.ServicesHeader);
            Assert.IsTrue(theServicesPage.ServicesHeader.Displayed);

            theMenuPage.clickOnWorkLink();
            Driver.waitForElement(theWorkPage.WorkHeader);
            Assert.IsTrue(theWorkPage.WorkHeader.Displayed);

            
            
        }

        [TestCleanup]
        public void CleanUp()
        {
            Driver.quit();
        }
    }
}
