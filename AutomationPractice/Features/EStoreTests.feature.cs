﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AutomationPractice.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("EStore Sanity Check")]
    public partial class EStoreSanityCheckFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "EStoreTests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "EStore Sanity Check", "Test scenarios of main functionality of the application", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC1. User registration and Sign in")]
        [NUnit.Framework.CategoryAttribute("logout")]
        public virtual void TC1_UserRegistrationAndSignIn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TC1. User registration and Sign in", new string[] {
                        "logout"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("I navigate to \'Home\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
   testRunner.And("Click \'Sign in\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
   testRunner.And("I can see \'Authentication\' label", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I type \'new user\' email", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
   testRunner.And("I click \'Create an account\' button on authantication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Title",
                        "FirstName",
                        "LastName",
                        "Email",
                        "Password",
                        "DateOfBirth"});
            table1.AddRow(new string[] {
                        "Mr.",
                        "John",
                        "Doe",
                        "",
                        "secret123!",
                        "7.July .1997."});
#line 11
   testRunner.And("I fill following fields in \'YOUR PERSONAL INFORMATION\' area", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "FirstName",
                        "LastName",
                        "Company",
                        "Address",
                        "Address2",
                        "City",
                        "State",
                        "Zip",
                        "Country",
                        "AdditionalInfo",
                        "HomePhone",
                        "MobilePhone",
                        "Alias"});
            table2.AddRow(new string[] {
                        "John",
                        "Doe",
                        "N/A",
                        "4200 Metropolitan Ave",
                        "N/A",
                        "Dallas",
                        "Texas",
                        "75210",
                        "United States",
                        "some info",
                        "33388555",
                        "33388555",
                        "Xata"});
#line 14
   testRunner.And("I fill following fields in \'YOUR ADDRESS\' area", ((string)(null)), table2, "And ");
#line 17
   testRunner.And("I click \'Register\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.Then("I can see users credentials on View my account button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC2. Buy one product added from main page by bank card")]
        [NUnit.Framework.CategoryAttribute("login")]
        public virtual void TC2_BuyOneProductAddedFromMainPageByBankCard()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TC2. Buy one product added from main page by bank card", new string[] {
                        "login"});
#line 25
this.ScenarioSetup(scenarioInfo);
#line 26
testRunner.Given("I navigate to \'Home\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
  testRunner.When("I click \'Add to cart\' button on product card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
  testRunner.And("I click \'Proceed\' in confirmation pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
  testRunner.And("I click \'Proceed to checkout\' button on Shopping Cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
  testRunner.And("I click \'Proceed on Address step\' button on Shopping Cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("I mark Terms of Service", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
  testRunner.And("I click \'Proceed on Shipping step\' button on Shopping Cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
  testRunner.And("I seleck payment method as \'Bank card\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
  testRunner.And("I see \'Bank card\' as selected payment method", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
  testRunner.And("I click \'Confirmation\' button on Shopping Cart page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
testRunner.Then("I can see order confirmation message", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC3. Product search, sorting, adding products to cart")]
        public virtual void TC3_ProductSearchSortingAddingProductsToCart()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TC3. Product search, sorting, adding products to cart", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 43
testRunner.Given("I navigate to \'Home\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
testRunner.When("I search for \'T-short\' item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
  testRunner.And("Sort \'ascending\' by price \'Price: Lowest first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
  testRunner.And("Sort \'descending\' by price \'Price: Highest first\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
  testRunner.And("I click \'Qwick view\' button on product card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
  testRunner.And("I set quantity to \'3\' colour to \'1\' select size \'L\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
  testRunner.And("I click \'Add to cart\' button on quickview card", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
  testRunner.And("I click \'Continue shopping\' in confirmation pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
  testRunner.And("I hover on Cart button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC3. Add item to cart via catalog")]
        public virtual void TC3_AddItemToCartViaCatalog()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TC3. Add item to cart via catalog", ((string[])(null)));
#line 70
this.ScenarioSetup(scenarioInfo);
#line 71
testRunner.Given("I navigate to ‘home’ page as ‘anonymous’ user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 72
testRunner.When("I click ‘ Dresses’ tab from menu bar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 73
testRunner.And("I select price in range ‘16-40’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
testRunner.And("I select ‘L size’ from catalog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
testRunner.And("I select ‘Maxi dress properties’ from catalog", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
testRunner.And("I add ‘to cart’  ‘selected’ item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
testRunner.And("I click ‘proceed to checkout’ button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
testRunner.And("I log out", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC4. Checking that item adding to cart via search field.Check sorting.Check compa" +
            "re,Check wishlist.")]
        [NUnit.Framework.CategoryAttribute("logout")]
        [NUnit.Framework.CategoryAttribute("login")]
        public virtual void TC4_CheckingThatItemAddingToCartViaSearchField_CheckSorting_CheckCompareCheckWishlist_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TC4. Checking that item adding to cart via search field.Check sorting.Check compa" +
                    "re,Check wishlist.", new string[] {
                        "logout",
                        "login"});
#line 81
this.ScenarioSetup(scenarioInfo);
#line 82
testRunner.Given("I enter ‘Dress’ to the search field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 83
testRunner.And("I click search icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
testRunner.Then("I sort selected item by ‘Lowest price’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
testRunner.And("I see that items sorted by lowest price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
testRunner.And("I add to ‘Compare’ second and third items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
testRunner.And("I add to ‘Wishlist’  fourth and fifth items", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
testRunner.When("I navigate to ‘compare list’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 89
testRunner.Then("I see two items and delete first", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 90
testRunner.And("add ‘to cart’ ‘second’ item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
testRunner.When("I navigate to ‘wishlist’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 92
testRunner.Then("I see  two items and delete second", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 93
testRunner.Then("I add ‘to cart’  ‘first’ item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("TC5. Check card and payment steps")]
        [NUnit.Framework.CategoryAttribute("login")]
        public virtual void TC5_CheckCardAndPaymentSteps()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TC5. Check card and payment steps", new string[] {
                        "login"});
#line 96
this.ScenarioSetup(scenarioInfo);
#line 97
testRunner.Given("I navigate to ‘home’ page as ‘logged in’ user", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 98
testRunner.When("I navigate to ‘cart’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 99
testRunner.And("I see 4 items have already added to the cart", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
testRunner.And("I check total  price", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
testRunner.And("I delete first item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
testRunner.And("I check total price again", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
testRunner.And("I add one Qty of item", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
testRunner.And("I check total price again", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 105
testRunner.Then("I proceed to checkout", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 106
testRunner.When("I navigate to ‘Order history’", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 107
testRunner.Then("I see  all information of my order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
