Feature: SkillsPage
	Functionality around Skills page

@mytag
Scenario: I am able to add new skills
	Given I login
	When  I am at skill page
	And I click the skills page
	When I click the add new skills button
	And I enter the new <Skills>
	When I click on dropdown to select the new skills
	And I select new skills fron dropdown
	When I click the add button
	

	Examples:
	| Skills      |
	| C#,Selenium |

	


	@mytag
Scenario: I am able to update skills
	Given I login
	When  I am at skill page
	And I click the skills page
	When I am at skills icons
	When I click the edit icon to update skills
	And I update the new <updateSkills>
	When I click on dropdown to update the new skills
	And I select to update  new skills fron dropdown
	When I click the update button

	Examples: 
	| updateSkills             |
	| C#,Selenium,BDD Specflow |
	


	@mytag
Scenario: I am able to delete skills
	Given  I login
	When  I am at skill page
	And I click the skills page
	When I click the delete icon to skills
	