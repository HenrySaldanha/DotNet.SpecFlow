Feature: BasicOperations
	Test basic math operations

Scenario: Add two positive numbers
	Given The first number is 5
	And The second number is 7
	When The two numbers are added
	Then The result should be 12

Scenario: Add two negative numbers
	Given The first number is -5
	And The second number is -12
	When The two numbers are added
	Then The result should be -17

Scenario: Add a positive number and a negative number
	Given The first number is 55
	And The second number is -23
	When The two numbers are added
	Then The result should be 32

Scenario: Subtract two positive numbers
	Given The first number is 10
	And The second number is 15
	When The two numbers are subtracted
	Then The result should be -5

Scenario: Subtract two negative numbers
	Given The first number is -2
	And The second number is -25
	When The two numbers are subtracted
	Then The result should be 23

Scenario: Subtract a positive number and a negative number
	Given The first number is 12
	And The second number is -12
	When The two numbers are subtracted
	Then The result should be 24

Scenario: Multiply two positive numbers
	Given The first number is 10
	And The second number is 50
	When The two numbers are multiplied
	Then The result should be 500

Scenario: Multiply two negative numbers
	Given The first number is -10
	And The second number is -12
	When The two numbers are multiplied
	Then The result should be 120

Scenario: Multiply a positive number and a negative number
	Given The first number is 5
	And The second number is -7
	When The two numbers are multiplied
	Then The result should be -35

Scenario: Divide two positive numbers
	Given The first number is 16
	And The second number is 4
	When The two numbers are divided
	Then The result should be 4.0

Scenario: Divide two negative numbers
	Given The first number is -10
	And The second number is -4
	When The two numbers are divided
	Then The result should be 2.5

Scenario: Divide a positive number and a negative number
	Given The first number is -30
	And The second number is 10
	When The two numbers are divided
	Then The result should be -3.0