Feature: Description
	Functionality around Description page

@mytag
Scenario: I am able to edit description
	Given I am login
	When I am at description page
	And I click on description icon
	When I eneter <Description>
	And  I click  save button
	Then Validate that description was save

	Examples: 
	| Description                                  |
	| Hi this is piue shri I am a Software Analyst |