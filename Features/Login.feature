Feature: Login

A short summary of the feature

@Sanity @1
Scenario: TC2a Enter Invalid Email
	Given I launch my browser and go to Landing Page
	And The cookies are accepted
	And I click login / Signup
	#And The cookies are accepted
	When I Enter the Incorrect Email in Signup
	Then I get the Email Address Error


Scenario: TC2b Enter Invalid Email
	Given I launch my browser and go to Landing Page
	And The cookies are accepted
	And I click login / Signup
	#And The cookies are accepted
	When I Enter the  Email in Signup
	And I enter Invalid password
	Then I get the Password Error
