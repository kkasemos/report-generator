Feature: Generate Company A Report
	In order to forecast demand for our products from Company A
	As a product manager
	I want to know how many our products Company A sell every day grouped by product name

@HappyPath
Scenario: No duplicate record
	Given Input is
		| Product Name | Amount |
		| Product A    | 100    |
		| Product B    | 200    |
		| Product C    | 300    |
	When It generates a report
	Then Output is
		| Product Name | Amount | Qty |
		| Product A    | 100    | 1   |
		| Product B    | 200    | 1   |
		| Product C    | 300    | 1   |

Scenario: Have duplicate records
	Given Input is
		| Product Name | Amount |
		| Product A    | 100    |
		| Product B    | 200    |
		| Product C    | 300    |
		| Product B    | 200    |
		| Product A    | 100    |
	When It generates a report
	Then Output is
		| Product Name | Amount | Qty |
		| Product A    | 100    | 2   |
		| Product B    | 200    | 2   |
		| Product C    | 300    | 1   |

@HappyPath
Scenario: The same product name has different amounts
	Given Input is
		| Product Name | Amount |
		| Product A    | 100    |
		| Product B    | 100    |
		| Product C    | 300    |
		| Product B    | 200    |
		| Product A    | 100    |
	When It generates a report
	Then Output is
		| Product Name | Amount | Qty |
		| Product A    | 100    | 2   |
		| Product C    | 300    | 1   |
	And Error log file contains
	"""
	Product A records have different amounts
	"""
