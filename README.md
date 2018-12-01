# myStore-specflow

This is a small example of using Behavior Driven Development test.

Technologies used: 
  Language   : C# .Net
  BDD Plug-in: SpecFlow 2.4.0.0
  C# Plug-in : Selenium.Support.3.141.0
  WebDriver  : geckodriver-v0.23.0-win64 (Firefox) 
  Feature file: (as below)

----------------------------------------------------------------------
  Feature file
----------------------------------------------------------------------

Feature: Product_Search_Test_Suite_01

As a tester, I want to test some basic search functionality to verify "search word" and "number of results counter"

Scenario: "Product_Search_Test_Suite_01"

	Given Scenario is "Product_Search-TS_01-TC_01"
	When I open Firefox with URL "http://automationpractice.com/index.php"

	#-----------------------------------------
	# Search-1 for "Blouse" 
	When I select field "Search" as "Blouse"
	And I click on "search" button

	# Verify results
	Then I see "BLOUSE" in "search word"
	And I see "1 result has been found." in "search result counter"
	
        #-----------------------------------------
  
	# Search-2 for "Printed"
	When I select field "Search" as "Printed"
	And I click on "search" button

	# Verify results
	Then I see "PRINTED" in "search word"
	And I see "5 results have been found." in "search result counter"

	#-----------------------------------------
	
----------------------------------------------------------------------
  
