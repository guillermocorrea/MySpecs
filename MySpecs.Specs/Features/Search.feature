Feature: Search
    In order to find articles on BDD
    As a BDD fanatic 
    I want to enter a keyword into a search engine and be shown a list of related websites


Scenario: Navigate to Search Engine
    When I enter http://www.google.com in the address bar
    Then I should be on the home page


Scenario: Perform search
    Given I am on the home page
    And I have entered BDD into the keyword textbox
    When I press the btnG button
    Then I should see a list of articles related to BDD