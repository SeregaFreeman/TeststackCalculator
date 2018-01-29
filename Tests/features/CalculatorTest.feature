Feature: CalculatorTest

@mytag
Scenario Outline: Add two numbers, remember result, then add another number to number in memory
	Given All old instances of app are closed
	    And new instance is open
		And view type is '<ViewType>'
	When User adds '999' to '12'
	And Adds result to memory
	And User enters '19' and adds it to number in memory
	Then the result should be '1030' on the screen

	Examples: 
	| ViewType   |
	| Standard   |
	| Scientific |

