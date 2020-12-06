Feature: Users
	

@Sanity_API
Scenario: Get List Of Users	
	When I send a GET request to "/api/users/"
	Then I get OK response

@Sanity_API
Scenario: Create User
	When I send a POST request to "/api/admin/users" with the following params
	| Name  | Email          | Login | Password |
	| User7 | User7@user.com | User7 | abc123   |
	Then I get OK response


@Sanity_API
Scenario: Update User
	When I send a PUT request to "/api/users/12" with the following params
	| Name  | Email          | Login | Password |
	| User6 | User5@user.com | User5 | abc123   |
	Then I get OK response

	@Sanity_API
Scenario: Delete User
	When I send a DELETE request to "/api/admin/users/13"
	Then I get OK response
	

	@Sanity_API
    Scenario: Verify Updated User Name
	When I send a PUT request to "/api/users/12" with the following params
	| Name    | Email            | Login | Password |
	| User100 | User100@user.com | User5 | abc123  |
	Then I verify that the user name in "/api/users/12" was updated to "User100"
