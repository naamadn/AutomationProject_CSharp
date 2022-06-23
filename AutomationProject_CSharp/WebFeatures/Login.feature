Feature: Login
	Login to website

@Sanity_Web
Scenario: perform login to website positive
	Given I launch the website login page	
	And I enter the following details and click on login button
	| UserName                    | Password |
	| original.user@yandex.com    | 123456   |	
	Then I should see my account


	@Sanity_Web	
	Scenario: perform login to website negative
	Given I launch the website login page
	And I enter the following details and click on login button
	| UserName                    | Password |
	| original.user@yandex.com    | 1234567  |	
	Then I should see my account