Feature: Registration
	So that i can use the site
	I need to register

@mytag
Scenario:Valid Registration
	Given I navigate to the site
	When I Click on the register link
	And  I enter firstname
	And  I enter the lastname
	And  I enter email "olumuyee@gmail.com"
	And  I enter Mobile number
	And  I enter password
	And  I confirm password
	And  I click on password
	And  I click on signUp
	Then I should be registered
