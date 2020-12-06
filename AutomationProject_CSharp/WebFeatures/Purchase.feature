Feature: Purchase
	Perform a purchase

@Sanity_Web
Scenario: Perform a purchase as a logged user	
	When I perform a purchase as a logged user	
	Then I get order complete message