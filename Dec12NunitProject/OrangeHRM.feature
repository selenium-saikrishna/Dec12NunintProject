Feature: Login and Logout module of OrangeHRM

@mytag
Scenario Outline: As an admin I should Alogin with all previlages 
	Given the browser is launched and orangehrm url is navigated to
	When I enter <username> and <password>
	And click on login button
	Then it should display <message>
		Examples: 
| username | password | message             |
| Sai      | Krishna  | Invalid credentials |
| Admin    | admin    | Welcome Admin       |





