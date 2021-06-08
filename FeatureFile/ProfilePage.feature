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
	|FirstName|  LastName |
	| piue@   |  shri@  |

@mytag
Scenario: I am able to edit availability..
	Given I am logged in
	And I am at the Profile page
	When I click on availability icon
	And I click on dropdown 
	And I select availability from dropdown
	Then Validate that availability added


	@mytag
Scenario: I am able to edit hours..
	Given I am logged in
	And I am at the Profile page
	When I click on hours icon
	And I click on hours dropdown 
	And I select hours from dropdown
	Then Validate that hours added


	@mytag
Scenario: I am able to edit earn target..
	Given I am logged in
	And I am at the Profile page
	When I click on earn target icon
	And I click on earn dropdown 
	And I select earn target from dropdown
	Then Validate that earn target added
	