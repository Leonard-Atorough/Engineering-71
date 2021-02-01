# C# SDET 1



------

# **Advanced Unit Testing and TDD**

- **What is the difference between the NUnit Framework and NUnit3TestAdapter?**
  - The test adapter allows us to run the NUnit tests on visual studio testing platform. The framework allows us to write NUnit tests in visual studio.
- **Give some other examples of NUnit test runners**
- **What does the attribute [SetUp] indicate and when does the associated method run?**
  - The setup attribute indicates methods that are to be run before every test or testcase.
- **If an NUnit class has a constructor, when does it run?**
  - Once, before any tests or testcases are run.
- **What is the major difference between the NUnit framework and MSTest?**
  - NUnit is a more mature testing framework with greater legacy support, designed purely for testing. It has more assert functionality than MSTest.
- **What are the three As of unit testing?**
  - Arrange, Act and Assert
- **What are the 5 FIRST characteristics of good unit tests?**
  - Fast
  - Isolated
  - Repeatable
  - Self checking
  - Timely
- **How do you exclude a test from being run?**
  - We can use the ignore attribute
- **What does the [TestCaseSource] attribute do?**
  - It is an attribute that allows us to make our tests more parameterised by moving some of our test data, used in the arrange step, out of our tests. We can use the [TestCaseData] attribute to create testcases which we can use in multiple tests.

 

# **Moq**

- **Why use Moq ?**
  - We use Moqs to remove concrete dependencies on code that is not being unit tested. In doing so we isolate the class under test and prevent our tests from failing due to outside influences.
- **How does Dependency injection aid unit testing?**
  - Dependency injection helps us to ignore the full functionality of other aspects of our code when testing the class in question. In this way, we don't need to worry about if the other areas of the code, potentially not under test, are working correctly.
- **How can we use a Moq to check if a method is called with the correct parameters?**
- **What is the difference between strict and loose mocking behaviour?**
  - Strick behaviour demands that only when the exact parameter values expected are passed through will the tests pass. Loose behaviour means that so long as the value types are the same, the test will pass.

 

# **APIs and REST**

- **What is an API?**
  - An API stands for an Application Programming Interface. It is an interface that allows communication between two programs without either program having to have any knowledge of the others inner workings
- **What does REST stand for?**
  - REST Stands for Representational State Transfer. Rest is a web API standard which meets certain criteria. These are: to provide access to its web resources in textual format and to support modification/reading of its resources according to stateless protocol.
- **What do we mean by caching?**
  - Caching is the storage of certain data on a client side program or machine with the purpose of speeding up a future queries.
- **What is the structure of an HTTP Request?**
  - The URL, the method, the headers and the body(data)
- **What is the structure of an HTTP Response?**
  - Status code, headers, body(data)
- **What should the RESTful endpoint myresource.io/Employees/6/Order/2 GET?**
  - The second order assigned to the sixth employee
- **Give some examples of header elements that can be used to control caching?**
  - Age
  - Duration
  - Date created
  - 

 

# **RestSharp**

- **What does the RestSharp library do?**
  - The restsharp library allows easy access to public APIs and provides tools for quick and easy HTTP data requests.
- What does an app.config file do? Why is it useful?
  - The app.config file is an XML file that allows us to store any variable configurations for the application. Its a place to store connection strings, application details, connection details to external services. 
- **Why did we create separate data handling and call manager folders in our Restsharp test framework?**
  - Single responsibility principle.



# **Refactoring and Code Smells**

- **Define the term "Refactoring"**
  - Refactoring is the process of improving the quality of code without changing its functionality
- When should you refactor your code?
  - Before adding ant updates of new features into that part of the code base.
  - After all unit tests pass and the code is functional
  - 
- When should you NOT refactor your code?
  - Before it is well covered by testing
  - 
- Define the term "Code Smells"
  - Code smells - something inappropriate in code that could lead to issues later down the line/confusion.
- Name some Code Smells
  - 
- What is feature envy and what should you do about it?
- If a class several methods which contain if/else or switch blocks that test a "type" attribute, what should you do about it?

 

# **Pair Programming**

- what is pair programming?
- why is it considered effective?
- what pitfalls should you try to avoid in pair programming?



# **Asynchronous Programming** 

- Why do we need to use asynchronous methods?
- What keywords should an asynchronous method use (and where?)
- What return types are allowed for asynchronous methods?
- What effect does the await keyword have?
- What is the naming convention for asynchronous methods?