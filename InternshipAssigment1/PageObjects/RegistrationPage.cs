using InternshipAssigment1.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipAssigment1.PageObjects
{
    class RegistrationPage
    {

        public RegistrationPage()
        {
            PageFactory.InitElements(Hooks.Driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "#login-form > div.alert.alert-successr")]
        private IWebElement successMessage { get; set; }

        [FindsBy(How = How.LinkText,Using = "Register")]
        private IWebElement register { get; set; }

        [FindsBy(How = How.Id, Using = "first Name")]
        private IWebElement firstName { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#last_name")]
        private IWebElement lastname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='mobile']")]
        private IWebElement mobile { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "confirm_password")]
        private IWebElement confirmpassword { get; set; }


        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailAddress { get; set; }

       
        [FindsBy(How = How.CssSelector, Using = "#signup-form > div.buttons-holder.text-center > button")]
        private IWebElement signUp { get; set; }

        public bool SucessMessageIsDisplayed()
        {
            try
            {

            }
            catch (Exception ex)
            {
            }
            return SucessMessage.Displayed;
        }



        public void EnterMobile(string mobileText)
        {
            mobile.SendKeys(mobileText);
        }


        public void Enterconfirmpassword(string confirmPasswordText)
        {
            confirmpassword.SendKeys(confirmPasswordText);
        }

        public void Enterpassword(string passwordText)
        {
            Password.SendKeys(passwordText);
        }

        public void EnterLastname(string lastnametext)
        {
            lastname.SendKeys(lastnametext);
        }

        public void ClickSignUP()
        {
            signUp.Click();
        }
        public void ClickonRegister()
        {
            register.Click();
        }
        public void EnterFirstName()
        {
            firstName.SendKeys("Muyiwa");
        }
        public void EnterEmailAddress(string myEmail)
        {
            emailAddress.SendKeys(myEmail);
        }

    }


}
