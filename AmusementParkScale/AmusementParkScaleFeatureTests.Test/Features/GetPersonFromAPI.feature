Feature: Calling The API

Scenario: The user calls the API
    Given the browser is opened in chrome
	 When the url https://dummyjson.com/users/1 is browsed
	 Then the API responds

Scenario: The User calls the API and get good Data
	Given the browser is opened in chrome
	 When the url https://dummyjson.com/users/1 is browsed
	 Then the API responds with data from user with id 1

