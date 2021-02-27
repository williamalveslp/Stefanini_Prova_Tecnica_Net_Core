Feature: UserSystem
	Testing the SignIn when add the info data.

@mytag
Scenario: Login with existing user
	Given that user inform UserName '123' and Password '456'
	When checks if the user exists
	Then should be returned the user data