Feature: Employee
In order to add,edit, delete employee records 
As an admin
I want to modify the employee details in dashboard

Background:
	Given I have browser with orangehrm page

#Scenario: Add Valid Employee
#	
#	When I enter username as 'Admin'
#	And I enter password as 'admin123'
#	And I click on login
#	And I click on PIM
#	And I click on Add Employee
#	And I fill the Add employee section
#		| firstname | middlename | lastname | employee_id | toggle_login_detail | username | password    | confirm_password | status   |
#		| Harshad   | A          | Lokare   | 101         | on                  | Jimmy    | Welcome@123 | Welcome@123      | disabled |
#	And I click on save employee
#	Then I should be navigated to personal details section with added employee records

Scenario Outline: Add Valid Employee
	
	When I enter username as 'Admin'
	And I enter password as 'admin123'
	And I click on login
	And I click on PIM
	And I click on Add Employee
	And I fill the Add employee section
		| firstname   | middlename   | lastname   | employee_id   | toggle_login_detail   | username   | password   | confirm_password   | status   |
		| <firstname> | <middlename> | <lastname> | <employee_id> | <toggle_login_detail> | <username> | <password> | <confirm_password> | <status> |
	And I click on save employee
	Then I should be navigated to personal details section with added employee records

	Examples: 
	| firstname | middlename | lastname | employee_id | toggle_login_detail | username | password    | confirm_password | status   |
	| harshad  | A          | lokare   | 102         | on                  | Jimmy    | Welcome@123 | Welcome@123      | disabled |





#Scenario: Add Valid Employee
#	Given I have browser with orangehrm page
#	When I enter username as 'Admin'
#	And I enter password as 'admin123'
#	And I click on login
#	And I click on PIM
#	And I click on Add Employee
#	And I enter firstname as 'harshad'
#	And I enter middlename 'harshad'
#	And I enter lastname 'harshad'
#	And I enter Employee Id as '101'
#	And I upload Employee Image ''
#	And I click on create credential
#	And I enter username 'harshad'
#	And I enter password 'harshad'
#	And I enter confirm password
#	And I select status as disables
#	Then I click on save

	      
	











#1. Navigate to the url
#2. Enter Admin username
#3. Enter password
#4. Click Login
#5. click on PIM
#6. Click on Add Employee
#7. Enter firstname
#8. Enter middlename
#9. Enter lastname
#10. Enter Employee Id
#11. Upload the employee image
#12. Check - create credential
#13. Enter Username
#14. Enter password
#15. Enter Confirm password
#16. Select status as Disabled
#17. Click on save
