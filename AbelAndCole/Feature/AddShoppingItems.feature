Feature: AddShoppingItems
	In order to add shopping items to the basket
	A customer will need to search and add

@mytag
Scenario: Add Shopping Items To The Basket
	Given that I navigate to "https://www.abelandcole.co.uk/?altmenu=carrot"
	And I click on accept to accept cookies
	And I enter the item name in the search bar "Brownie Tray Organic Daylesford"
	And I click on the search button
	And I click on Add button
	And I enter the item in the search bar "Hummus Chips Organic"
	And I click on search button
	And I click on Addhumus  button
	And I click on plus button
	And I click on plushummus button
	And I enter the popcorn item in the search bar "Simply Salted Popcorn Organic"
	And I click on searchpopcorn button
	And I click on Addpopcorn button
	And I click on pluspopcorn button
	Then the basket should display six items