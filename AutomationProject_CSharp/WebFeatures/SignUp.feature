Feature: SignUp
	Sign up to website

@Sanity_Web
Scenario: Sign up to website_positive
   Given I launch the website login page	
	When I sign up to website with the following email
		| Email            |
		| ert@hfr1234901.com | 
	And I create an account with the following details
	| Title |  First Name | Last Name | Password | Address       | City            | State           | Zip      | Phone          |
	|Mrs    |  Donna      | Martin    | 98765    | Beverly Hills |  Los Angeles    | California      |  90210   |   032567890    |
	Then I go to my account

@Sanity_Web
Scenario: Sign up to website_negative
   Given I launch the website login page	
	When I sign up to website with the following email
		| Email           |
		| ert@hfr1234.com | 	 
	Then I get a message that email address has already been registered