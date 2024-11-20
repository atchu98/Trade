Feature: Forex

A short summary of the feature
@Sanity @1
Scenario: TC1 Confirm Forex Page Title is correct
	Given I launch my browser and go to the Forex Page
	And The cookies are accepted
	When I click on the Trade Nations logo
	Then I should see the Title

