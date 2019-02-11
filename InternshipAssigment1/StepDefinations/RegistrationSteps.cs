using InternshipAssigment1.PageObjects;
using InternshipAssigment1.Utilities;
using NUnit.Framework;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace InternshipAssigment1.StepDefinations
{
    [Binding]
    public class RegistrationSteps
    {
        RegistrationPage registration;

        public RegistrationSteps()
        {
            registration = new RegistrationPage();
        }
       [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("https://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();
        }
        
        [When(@"I Click on the register link")]
        public void WhenIClickOnTheRegisterLink()
        {
             registration.ClickonRegister();
        }
        
        [When(@"I enter the firstname")]
        public void WhenIEnterTheFirstname()
        {
            registration.EnterFirstName()

        }
        
        [When(@"I enter the lastname")]
        public void WhenIEnterTheLastname()
        {
            registration.EnterLastname("mylast to Enter");
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);
        }

        [When(@"I enter Mobile number")]
        public void WhenIEnterMobileNumber()
        {
            registration.EnterMobile("07473373303");
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            registration.Enterpassword("master2000");
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            registration.Enterconfirmpassword("master2000");
        }
        
        [When(@"I click on password")]
        public void WhenIClickOnPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on signUp")]
        public void WhenIClickOnSignUp()
        {
            registration.ClickSignUP();
        }

        [Then(@"I should be registered")]
        public void ThenIShouldBeregistered()
        {
            Thread.sleep(30000);

            //NUnit Assertion
           
            Assert.Equals(registration.sucessMessageIsDisplayed(), true);
            Assert.IsTrue(registration.sucessMessageIsDisplayed(),"Error message; Registration failed");

            registration.sucessMessageIsDisplayed().should().BeTrue(),"Error message; Registration failed");
        }
    }
}
