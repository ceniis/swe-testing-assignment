# Testing Strategy:
- Unit tests were developed to test methods from class Calculator    
- Integration tests were developed to test how the WinForms UI methods interact with class Calculator and UI     
- Manualal tests were developed that buttons function correctly, results are displayed properly, and the overall user interaction with the application behaves as expected

**Some aspects were not tested, such as:**
- Performance of the application    
- Accessibility or usability metrics

# Lecture Concepts:
The test suite follows the Testing Pyramid principle, where the majority of tests are unit tests, fewer are integration tests, and the smallest portion consists of end-to-end or manual tests
***Testing pyramid:***
- Manual testing - *End-To-End*     
- - Integration - *Integration*     
- - - Unit - *Unit*     

During manual testing Black-box testing was used due to nature of working with application itself via UI without having access to source code.    
On the other hand unit and integration tests are White-box testing because during them we have access to source code.

All tests implemented in this project are functional tests. They verify that the calculator performs mathematical operations correctly and that the UI correctly reflects the results of these operations.
Non-functional testing was not implemented because the main goal of the project was to validate the correctness of the application’s functionality.

The implemented test suite can be used for regression testing in future updates of the project. If new features are added or existing logic is modified, the tests can be executed to verify that previously working functionality still behaves correctly.

***Test Results:*** All of developed unit tests passed

| №   | Name                    | Type        | Result |
| --- | ----------------------- | ----------- | ------ |
| 1   | UIAdditionTest          | Integration | Passed |
| 2   | UIClearResetsResult     | Integration | Passed |
| 3   | AdditionTest            | Unit        | Passed |
| 4   | BigNumbersTest          | Unit        | Passed |
| 5   | ClearResetsResult       | Unit        | Passed |
| 6   | DivisionByZeroThrows    | Unit        | Passed |
| 7   | DivisionTest            | Unit        | Passed |
| 8   | MultiplicationTest      | Unit        | Passed |
| 9   | NegativeSubtractionTest | Unit        | Passed |
| 10  | SubtractionTest         | Unit        | Passed |       

Manual testing also resulted in positive results with all of functionality working correctly with UI and coming with correct math operations result  

<img width="486" height="423" alt="image" src="https://github.com/user-attachments/assets/7511ddb5-557a-4c21-a856-e384477e8423" />
