Feature: Store
  In order to create an environment for managing pet shop
  As a user
  I want to handle the orders

Scenario: Find order order by Id
Given I have base url 'https://petstore.swagger.io/v2/' and resource store 'store/order/9'
When I do the get request
Then I should get the response code as 200


Scenario: Find purchase order by non-existing Id
Given I have base url 'https://petstore.swagger.io/v2/' and resource store 'store/order/200'
When I do the get request
Then I should get the response code as 404
