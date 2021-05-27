Feature: ProfilePppage
	Functionality around Profile page

@mytag
Scenario: I am able to edit new profile details
	Given I am logged in
	And I am at the Profile page
	When I click on profile 
	And I enter the new name
	And I enter the new serName
	When I click the save button
	Then Validate that profile  is added