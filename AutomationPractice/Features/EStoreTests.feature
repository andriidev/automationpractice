Feature: EStoreTests

Scenario: Add two numbers
	Given I navigate to 'Home' page
	#And I navigate to 'Home' page
	#And I see logo
	#When I press add
	#Then the result should be 120 on the screen

Scenario:  User registration
	Given I navigate to 'Home' page
	  And Click 'Sign in' button
	  And I can see 'Authentication' label
	When I type 'new user' email
	  And I click 'Create an account' button
	  And I fill in 'YOUR PERSONAL INFORMATION' area
	  | Title | First name | Last name | Email | Password   | Date of Birth |
	  | Mr.   | John       | Doe       |       | secret123! | 07.07.1997    |
	  And I fill in 'YOUR ADDRESS' area
	  | First name | Last name | Company | Address               | Address 2 | City   | State | Zip      | Country | Additional info | Home phone | Mobile phone | alias |
	  | John       | Doe       | N/A     | 4200 Metropolitan Ave | N/A       | Dallas | Texas | TX 75210 | US      | some info       | 33388555   | 33388555     | Xata  |
	  And I click 'Register' button
	Then I can see users credentials on 'view my account' button