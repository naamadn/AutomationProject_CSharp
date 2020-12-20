Feature: dbTests
	

@Sanity_DB
Scenario: login with credentials from DB
	Given I launch the website login page	
	When I login with credentials from DB
	Then I should see my account