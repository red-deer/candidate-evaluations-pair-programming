# Test coding test
The goal of this series of exercises is to assess if the candidate is able to:
1) Read dev code and understand the high-level meaning of the MUT (Method Under Test).
1) Write/tell a decent spec for a functionality (reverse engineering) and critique
1) Find all the cases for achieving full coverage of the MUT
1) Write a basic unit test and a slightly more tricky exception-catching unit test.
1) Write the same tests using Specflow and their associated step definitions
1) Be able to use the full force of specflow (esp: scenario outline/table)

# Tasks
## Share a new link from https://cryptpad.fr/drive/ with candidate.
## Copy-paste the file called Start/UtilityDiscountLib.cs on codeshare
## Ask the candidate to comment the MUT and tell what it does
### Ask candidate: Anything weird about the business logic? 
     Answer: For SalesAmnt > 20,000 -> No discount!
### Ask candidate to Enumerate all the test cases you need to get 100% coverage
## Unit tests: Copy paste the file Start/UnitTests.cs on codeshare 
### Add //GIVEN?THEN?WHEN to make the code more friendly (no Specflow)
### Ask candidate to write the unit test that covers the first case
### Ask candidate to write the unit test that covers the exception thrown
### Bad points for code undetailed, or with errors.
## Specflow scenario: copy-paste the template in Start/DiscountTest.feature
### Ask the candidate to fill in the code with more scenarios
### Special bonus if they start with a table or a scenario outline
### If the code is not great, make sure you put it into shape before the next exercise
### If the code is really bad, don't bother, just finish the interview.
## Specflow Step Definitions: copy-paste the file Start/Discount.Specs.Steps.Discount to codeshare
### Ask the candidate to write the corresponding step-definitions for their scenario(s).
### Added bonus if they manage to pass the context value properly between two steps-defs.