Feature: LanguagePage
	Functionality around Language page

@mytag
Scenario: I am able to add new Language
	Given I at login
	When  I am at Language page
	And I click the Language page
	When I click the add new Language button
	And I enter the new Language
	When I click on dropdown to select the new Language
	And I select new Language fron dropdown
	Then I click the add button
	


	@mytag
Scenario: I am able to update Language
	Given I at login
	When  I am at Language page
	And I click the Language page
	When I am at Language icons
	When I click the edit icon to update Language
	And I update the new Language
	When I click on dropdown to update the new Language
	And I select to update  new Language fron dropdown
	Then I click the update button
	


	@mytag
Scenario: I am able to delete Language
	Given I at login
	When  I am at Language page
	And I click the Language page
	When I click the delete icon to Language
	
	