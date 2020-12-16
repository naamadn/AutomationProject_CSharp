Feature: Purchase
	Perform a purchase

#@Sanity_Web
#Scenario: Perform a purchase as a logged user	
#	When I perform a purchase as a logged user	
#	Then I get order complete message

@Sanity_Web
Scenario: Perform a purchase as a logged user	
	When I login with valid credentials
	And I mouse hover Dresses and select Summer Dresses
	And I filter by small size
	And I filter by in stock items
	And I sort by Price: Lowest first
	And I select the first dress on the list
	And I add item to cart
	And I proceed to checkout
	And I accept the terms of service and checkout
	And select paying method of BankWire
	And I confirm my order
	Then I get order complete message