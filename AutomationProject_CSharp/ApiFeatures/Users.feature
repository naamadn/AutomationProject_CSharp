Feature: Users
	

@Sanity_API
Scenario: Get List Of Users	
	When I send a GET request to "/api/users/"
	Then I get OK response
	And I print user details where id is "2"


@Sanity_API
Scenario: Create User
	When I send a POST request to "/api/admin/users" with the following params
	| Name  | Email            | Login  |         Password   |
	| User25 | User25@user.com | User25 | abc25              |
	Then I get OK response


@Sanity_API
Scenario: Update User
	When I send a PUT request to "/api/users/2" with the following params
	| Name  | Email               | Login     | Password |
	| User88   | User5@user.com   | User12345 | abc123   |
	Then I get OK response

	@Sanity_API
Scenario: Delete User
	When I send a DELETE request to "/api/admin/users/5"
	Then I get OK response
	

	@Sanity_API
    Scenario: Verify Updated User Name
	When I send a PUT request to "/api/users/2" with the following params
	| Name    | Email            | Login     | Password |
	| User89   | User5@user.com   | User12345 | abc123  |
	Then I verify that the user name in "/api/users/2" was updated to "User89"
