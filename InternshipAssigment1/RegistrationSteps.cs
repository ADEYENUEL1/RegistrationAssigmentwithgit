using TechTalk.SpecFlow;

namespace InternshipAssigment1
{
    [Binding]
    public class RegistrationSteps
    {
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();
        }
    }
}
