Feature: Manual Input Handling

  Scenario: The user provides 3 invalid inputs
    Given the user is prompted to input a weight
    When the user provides an invalid input
    And the user provides another invalid input
    And the user provides another invalid input
    Then the user should be informed that they have reached the maximum number of invalid attempts
    And the process should end


