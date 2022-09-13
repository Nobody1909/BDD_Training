#ATDD
Feature: Login 
In order to maintain the employee record
As a user
I want to login into portal

Background: 
	Given I have browser with orangehrm page

Scenario: Valid Credential
When I provide username as 'Admin'
And I provide password as 'admin123'
And I Click on login
Then I should navigate to 'PIM' dashboard screen

Scenario Outline: Invalid Credential
When I provide username as '<username>'
And I provide password as '<password>'
And I Click on login
Then I should get error message as '<error_msg>'

Examples:
| username | password | error_msg           |
| john     | admin123 | Invalid credentials |