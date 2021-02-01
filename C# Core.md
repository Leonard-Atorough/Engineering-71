# C# Core

 

------

1. What is the difference between .NET framework and .NET core?

![](https://csharpcorner-mindcrackerinc.netdna-ssl.com/article/difference-between-net-framework-and-net-core/Images/DotNet-Architecture.jpg)

.NET Framework is not multiplatform, .NET Core is multiplatform. 

1. What is an exception?

An exception is a problem that arises during the execution of a program. They provide a way to transfer control from one part of a program to another.

1. What is a conditional breakpoint?

Conditional breakpoint temporarily suspends the execution of a program once a certain condition has been met.

1. What is meant by a "Strongly Typed Language"?

- statically typed
- memory safe
- Type safe

1. What is WPF?

   Windows Presentation framework; a .NET tool for building frontend systems and providing linkages to functional code via the code-behind layer.

2. What is casting?

   Casting is the implicit or explicit conversion of a value from one data type to a similar data type. ( I.e. int to double)

3. What is parsing?

   Parsing, on the other hand, is the conversion from one data type to another. It creates a new object and returns a reference to it.

4. What is a stack, what is a heap?

   The stack is responsible for keeping track of what's executing in our code. The stack is built as code runs and functions are called. We can only utilise what's at the top of the stack (?? so therefore when functions are called multiple times, each call is a new item on the stack??)

   - What goes on the stack?

   The heap, on the other hand, is responsible for keeping track of our objects. There is no stipulation for 

5. What makes up a method signature?

6. How would you find out the largest value an Int32 value type can be?

7. What's compile time and run time?

   Compile time is when the source code is converted into the intermediate executable language. Run time is when this executable is running.

8. Why is C# described as memory safe

9. What is method overloading?

   Declaring the same method multiple times either with different numbers of parameters of with different data types for parameters (basically, different parameters.)

10. What is the best Collection type for fast access of sequentially stored items? 

    It depends on the way in which we wish to access the data in the collection.

    An array is fast for sequential access because of its fixed length. Since the length is known and is an allocated space of memory, it is fast. Arrays a read-centric.

    Hashsets are also fast since they store items based on their hashcode but only have to store values (as opposed to key value pairs held by dictionaries).

11. How can you edit the text on a Button in WPF?

12. What is the smallest floating point number type? How many bits?

13. What data types can int be safely converted to (long, float, double, decimal (check)

14. What does the using keyword do?

15. Give an example of a ternary operator

16. What is a nullable type?

17. In handling exceptions, when is the finally block run?

18. In a method signature, what does the void keyword mean?

19. What is an out parameter?

    The out parameter is a value passed by reference

20. What are named parameters and why are they useful?

    Named parameters mean that the parameter for each argument can be specified by name, freeing us from having to pass values to parameters in a sequential order.

21. Why should we use string builder?

    It alters the string at its original memory, rather than add a copy onto the heap when the string is altered or used.

    

    What are collections?

    

    What does the null coalescing operator do?

    It allows you check if the variable is null

    



> More research per night. Look through old notes.
>
> FizzBuzz code challenge



```c#
            for (int i = 1; i <= 180; i++)
            {
                if (i % 3 == 0 & i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
```

