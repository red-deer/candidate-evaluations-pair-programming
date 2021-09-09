Feature: DiscountCalculator

@mytag
Scenario: Sales Amount is Greater or Equal than 1000 
    Given sales is equal to 1000
    When I calculate the Discount
    Then the result should be 950

