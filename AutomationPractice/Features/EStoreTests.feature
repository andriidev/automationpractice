Feature: EStoreTests

@logout
Scenario: TC1. User registration
	Given I navigate to 'Home' page
	  And Click 'Sign in' button
	  And I can see 'Authentication' label
	When I type 'new user' email
	  And I click 'Create an account' button on authantication page
	  And I fill following fields in 'YOUR PERSONAL INFORMATION' area
	  | Title | FirstName | LastName | Email | Password   | DateOfBirth |
	  | Mr.   | John      | Doe      |       | secret123! | 7.July .1997.  |
	  And I fill following fields in 'YOUR ADDRESS' area
	  | FirstName | LastName | Company | Address               | Address2 | City   | State | Zip   | Country       | AdditionalInfo | HomePhone | MobilePhone | Alias |
	  | John      | Doe      | N/A     | 4200 Metropolitan Ave | N/A      | Dallas | Texas | 75210 | United States | some info      | 33388555  | 33388555    | Xata  |
	  And I click 'Register' button
	Then I can see users credentials on View my account button


#@login
Scenario: TC2. Buy a product
Given I navigate to 'Home' page
#  And I switch to Best sellers tab
# When I hower on product with discount in the list
  When I click 'Add to cart' button on product card
  And I click 'Proceed' in confirmation pop up
#  And I check Total sum in cart
#  And I click 'Proceed to checkout' in confirmation pop up
#  And I check Adress
#  And I click 'Proceed to checkout' in confirmation pop up
#  And I check shipping
#  And I mark Terms of Service
#  And I click 'Proceed to checkout' in confirmation pop up
#  And I seleck payment method as 'Bank card'
#  And I click 'Proceed to checkout' in confirmation pop up
#  And I see 'Bank card' as selected payment method
#  And I clcik 'Confirmation' button
#Then I can see confirmation message 'Your order on My Store is complete.'


@login
Scenario: TC. Adding products to cart
Given I switch to Best sellers tab
When I hower on product with discount in the list
  And I click 'Add to cart' button on product card
  And I click 'Continue shopping' in confirmation pop up
  And I hover on Cart button
Then I can see added product in the cart
  And the price is correct according to discount
  And I delete added product from cart
When I search for 'Faded Short Sleeve T-shirts' item
  And I hower on found item
  And I click 'Qwick view' button on product card
  And I set quantity to '3'
  And I select colour to 'blue'
  And I select size 'L'
  And I click 'Add to cart' button on quickview card
  And I click 'Continue shopping' in confirmation pop up
  And I hover on Cart button
Then I can see added product in the cart
  And the price is correct according to selected quantity
  And I delete added product from cart
When I navigate to catalog
  And I set filter parameter
  And I change product layout from grid to list
  And I hower on product in the list
  And I click 'More' button on product card
  And I set quantity to '2'
  And I select colour to 'orange'
  And I select size 'L'
  And I click 'Add to cart' button on product detail page
  And I click 'Proceed to checkout' in confirmation pop up
Then I can see added product in the cart
  And the price is correct according to selected quantity



Scenario: TC3. Add item to cart via catalog
Given I navigate to ‘home’ page as ‘anonymous’ user
When I click ‘ Dresses’ tab from menu bar
And I select price in range ‘16-40’
And I select ‘L size’ from catalog
And I select ‘Maxi dress properties’ from catalog
And I add ‘to cart’  ‘selected’ item
And I click ‘proceed to checkout’ button
And I log out

@logout @login
Scenario: TC4. Checking that item adding to cart via search field.Check sorting.Check compare,Check wishlist.
Given I enter ‘Dress’ to the search field
And  I click search icon
Then I sort selected item by ‘Lowest price’
And I see that items sorted by lowest price
And I add to ‘Compare’ second and third items
And I add to ‘Wishlist’  fourth and fifth items
When I navigate to ‘compare list’
Then I see two items and delete first 
And  add ‘to cart’ ‘second’ item
When I navigate to ‘wishlist’
Then I see  two items and delete second
Then I add ‘to cart’  ‘first’ item

@login
Scenario: TC5. Check card and payment steps
Given I navigate to ‘home’ page as ‘logged in’ user
When I navigate to ‘cart’
And I see 4 items have already added to the cart
And I check total  price
And I delete first item
And I check total price again
And I add one Qty of item
And I check total price again
Then I proceed to checkout
When I navigate to ‘Order history’
Then I see  all information of my order
