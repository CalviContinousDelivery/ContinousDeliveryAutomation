Feature: CustomLibraryFeature to Test custom library

@Category1
Scenario Outline: Add two numbers
	Given Enter <Number1> and <Number2> in first text box	
	When Click on Add button	
	Then Verify that result is <Result> in the result textbox

Examples: 
| Number1 | Number2 | Result |
| 6       | 2       | 8      |
