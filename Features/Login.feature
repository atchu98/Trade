Feature: Login

A short summary of the feature

@Sanity @1
Scenario: TC2a Enter Invalid Email
	Given I launch my browser and go to Landing Page
	When I click login
	And On the Signup Enter the Incorrect Email
	Then I get the Email Address Error



