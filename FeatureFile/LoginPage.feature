Feature: LoginPage
	In order to test the login fuction.

@mytag
Scenario: Vailid cred are used to login successfully
         When I lunch the application
	     And I click the signin  link
	     When I enter valid Cred
	     And  I click the login button
	     Then I shoul be able to login successfully

		 @mytag
Scenario:  Invalid emailId is used should result failure to login 
         When I lunch the application
	     And I click the signin  link
	     When I login with emailId "piue@gmail.com"
	     And  I click the login button
	     Then I should be not login 

		  @mytag
Scenario:  Invalid password is used should result failure to login 
         When I lunch the application
	     And I click the signin  link
	     When I login with <emailId> and with <password>
	     And  I click the login button
	     Then I should be not login 
		 Examples: 
	| emailId             | password |
	| piue1@gmail.com     | 123123   |
	| abc1234@gamil.com   | 000test  |


