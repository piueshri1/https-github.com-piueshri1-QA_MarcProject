Feature: ProfilePppage
	Functionality around Profile page

@mytag
Scenario: I am able to edit new profile details
	Given I am logged in
	And I am at the Profile page
	When I click on profile 
	And I enter new firstname < FirstName >
	And I enter new lastname < LastName >
	When I click the save button
	Then Validate that profile  is added

	Examples: 
	| FirstName |  LastName |
	| piue@0    |  shri@0   |

	
	