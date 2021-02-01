# QUICKFIRE QUESTIONS

## Introduction to Entity Framework

**What is Entity Framwork**

- Entitiy framework is an object relatonal mapping framework for .Net applications supported by microsoft. 
- It allows developers to utilise data via objects of generated classes without having to worry about the underlying database. 
- Developers can create and maintain applications utilising the data without having to write as much cumbersome code to manage access.

**NorthwindContext had DbSet (of Customer objects) - what did it do?**

DBset classes represent an entity set that can be used for CRUD operations. They are mapped to classes that represent tables within the database. They allow us to interact with the database.

**What is LINQ?**

- Language INtegrated Query is a .NET framework component that adds native querying functionality to .NET languages. 
- It does so by introducing query expressions, similar to SQL, which can be used to effectively query datasets such as arrays, enumerable classes, relation databases, etc

**LINQ uses two syntaxes - Name and describe them**

- Query Syntax is written in a similar format to SQL queries but with the select statement coming at the end of the query.

- Method Syntax which makes use of lambda expressions to produce compact queries. It's what the compiler breaks the query syntax down to.

**When is a LINQ query executed?**

A LINQ Query is executed when the variable is iterated over, not when the query is created. This is called deferred execution.

**What are the advantages of using EF over raw SQL?**

- Auto generated code for relational mapping
- Full developer support for debugging
- Query from C# Code
- Shorter development time
- Simplifies the querying process.



**What is a connection string used for – what information does it contain?**

The connection string is used to identify the database the for application to connect to as well as the means to connect to it.

## Entity Framework

**In the context of Entity Framework, what does scaffolding mean?**

Scaffolding is the name used to describe the automatic code generation process which produces an entity framework model for an existing/specified database

**When a class is generated from a database, what does it contain?**

The class is related to a table in the database and contains properties which relate to the columns in the given table.

**What does the DbContext class contain?**

The BD Context class contains DBset classes, an OnConfiguration method and an OnModelCreatingMethod.

**How are 1 to many relationships represented in the code model?**

Represented using lists.

**What is the using keyword used for?**

The using keyword encapsulates a code scope where our queries will be managed, in relation to the specified DbContext??

Provides a convenient syntax that ensures the correct use of  iDisposable objects

**What is meant by a partial class and why is it useful?**

The partial keyword indicates that other parts of the class can be defined in the namespace. A single class functionality can be implemented across many locations in the given namespace.

**What do we mean by the term model first approach to EF?**

Model first allows us to create a new model using the entity framework designer and then generate a database schema from the model.

**What is EF Migrations?**



**LINQ and Lambda**

**How do you load associated objects in a query?**

Associated subjects in a query are loaded using Joins 

**Why isn’t eager loading enabled by default?**

Eager loading is not as efficient as lazy-loading once query returns become bigger and more complex. Eager loading means that the query is executed as soon as it is made, not as soon as it is requested/used.

**What is a Lambda expression? Why is it used in LINQ queries?**



**What does x => x * x mean?**

This means that taking the parameter x, multiply x by itself.

**What is an anonymous method?**

An anonymous method is a method without a name but with a body. They allow us to pass blocks of code as a delegate parameters. Anonymous methods don't need a return type, this is inferred from the return statement inside the method body.

**What is Expression body syntax?**



**XML and JSON**

Describe the JSON structure

What C# collection does JSON correspond to? 

What data type are the keys in JSON ?

Describe the XML structure

What is the difference between XML and HTML?

Why are JSON and XML used?



# 24/11/2020

## BASIC CRUD OPERATIONS

```C#
///READ - R
                foreach (var customer in db.Customers)
                {
                    Console.WriteLine($"Customer {customer.ContactName} has ID {customer.CustomerId} and lives in {customer.City}");
                }

///CREATE - C
            var newCustomer = new Customer
            {
                CustomerId = "ARTYO",
                ContactName = "Artyom Chrburek",
                CompanyName = "KatFud ltd",
                City = "Vladivostok"
          	};

            db.Customers.Add(newCustomer);
            db.SaveChanges();

///DELETE - D
            Find customer by primary key
            var selectCustomer = db.Customers.Find("MAND");
            or use first or default
            var selectedCustomer = db.Customers.Where(c => c.CustomerId == "MANDA").FirstOrDefault();

            db.Customers.Remove(selectedCustomer);
            db.SaveChanges();

///UPDATE -U
            var updateCustomer = db.Customers.Find("ARTYO");
            updateCustomer.City = "Minsk";
            db.SaveChanges();


```



# 25/11/2020

## USING LINQ AND QUERY SYNTAX

​			

```C#
			var londonQuery =
                 from c in db.Customers
                 where c.City == "London"
                 orderby c.ContactName
                 select c;

            foreach (var item in londonQuery)
            {
                Console.WriteLine(item);
            }

            var orderQuery =
                from order in db.Orders
                where order.Freight > 750
                select order;

            foreach (var o in orderQuery)
            {
                Console.WriteLine(o.ToString());
            }

            WHERE
            var londonBerlinQuery =
                (from c in db.Customers
                 where c.City == "London" || c.City == "Berlin"
                 select c).ToList();

            foreach (var c in londonBerlinQuery)
            {
                Console.WriteLine(c);
            }

            Anonymous classs
            var example = new { Name = "Nish", Age = 22 };

            GROUPBY
            var groupQuery =
                from p in db.Products
                group p by p.SupplierId into groupedProducts
                select new
                {
                    supplierID = groupedProducts.Key,
                    unitsOnStock = groupedProducts.Sum(c => c.UnitsInStock)
                };

            foreach (var item in groupQuery)
            {
                Console.WriteLine(item);
            }

            ORDERBY
            var orderQuery =
                from p in db.Products
                orderby p.UnitPrice descending
                select p;
            foreach (var item in orderQuery)
            {
                Console.WriteLine($"{item.ProductId} - {item.UnitPrice}");
            }
```



## OTHER CRUD OPS WITH LINQ

```C#
            CREATE
            var newCustomer = new Customer
            {
                CustomerId = "BABI",
                ContactName = "Babish Binging",
                CompanyName = "Basics Ltd",
                City = "New York"
            };

            db.Customers.Add(newCustomer);
            db.SaveChanges();

            UPDATE
            var selectedCustomer =
                from c in db.Customers
                where c.CustomerId == "BABI"
                select c;

            foreach (var item in selectedCustomer)
            {
                item.City = "Chicago";
            }
            db.SaveChanges();

            DELETE
            var deleteCustomer =
                from c in db.Customers
                where c.CustomerId == "BABI"
                select c;

            foreach (var item in deleteCustomer)
            {
                db.Customers.Remove(item);
            }
            db.SaveChanges();
```


## DELEGATES AND LMABDA EXPRESSIONS

            static bool IsEven(int num) => num % 2 == 0;
            ===
            var nums = new List<int> { 3, 4, 1, 5, 6, 2, 7, 2 };
    
            var listCount = nums.Count();


```c#
        int countEven = 0;

        foreach (var item in nums)
        {
            if (IsEven(item)) { countEven++; }
        }

        int evenCount = nums.Count(IsEven);
        Console.WriteLine(evenCount);

        //DELEGATES AND ANONYMOUS METHODS
        int evenCount = nums.Count(delegate (int n) { return n % 2 == 0; });
        //LAMBDA EXPRESSION
        int evenCountLambda = nums.Count(n => n % 2 == 0);

        List<Person> peopleList = new List<Person>
        {
            new Person{Name = "Will", Age =22},
            new Person{Name = "Bob", Age=33},
            new Person{Name = "Andy", Age = 55},
            new Person{Name = "Laura", Age = 60}
        };

        var peopleCount = peopleList.Count();
        var yougPeopleCount = peopleList.Count(a => a.Age < 30);
        var totalAge = peopleList.Sum(a => a.Age);
        var olderPeopleTotal = peopleList.Sum(o => o.Age > 30 ? o.Age : 0);
```


## METHOD SYNTAX, QUERIES AND CRUD

```c#
            //LAMBDA EXPRESSIONS AND METHOD SYNTAX
            //WHERE
            var selectQuery = db.Customers.Where(c => c.City == "London" || c.City == "Berlin").OrderBy(c => c.ContactName);

            foreach (var c in selectQuery)
            {
                Console.WriteLine(c);
            }
            ///GROUPBY
            var groupQuery = db.Products.GroupBy(p => p.SupplierId).Select(newGroup => new
            {
                SupplierID = newGroup.Key,
                UnitsOnStock = newGroup.Sum(c => c.UnitsInStock)
            });

            foreach (var item in groupQuery)
            {
                Console.WriteLine(item);
            }

            //ORDERBY
            var orderQuery = db.Products.OrderBy(p => p.QuantityPerUnit).ThenByDescending(q => q.ReorderLevel);

            foreach (var item in orderQuery)
            {
                Console.WriteLine($"{item.QuantityPerUnit} - {item.ReorderLevel}");
            }

            //THE ABOVE IN QUERY SYNTAX

            var orderQuery2 =
                from c in db.Products
                orderby (c.QuantityPerUnit)
                orderby (c.ReorderLevel) descending
                select new { c.QuantityPerUnit, c.ReorderLevel, c.ProductId, c.ProductName };

            foreach (var item in orderQuery2)
            {
                Console.WriteLine(item);
            }

            //CRUD OPERATIONS WITH METHOD SYNTAX
            //CREATE
            var newCustomer = new Customer
            {
                CustomerId = "BILB",
                ContactName = "Bilbo Baggins",
                CompanyName = "Shire inc",
                City = "Shireville"
            };

            db.Customers.Add(newCustomer);
            db.SaveChanges();

            //READ
            db.Customers.ToList().ForEach(c => Console.WriteLine(c));

            //UPDATE
            var selectedCustomer = db.Customers.Where(c => c.CustomerId == "BILB").FirstOrDefault().City == "Shire";

            //DELETE
            var removeCustomer = db.Customers.Where(c => c.CustomerId == "BILB").FirstOrDefault();
            db.Customers.Remove(removeCustomer);
            db.SaveChanges();
```


## INCLUDES AND INNER JOINS

```C#
            //USING JOINS - EAGER LOADING
            var queryOrderWithCustomer =
                from order in db.Orders.Include(o => o.Customer)
                where order.Freight > 750
                select order;

            foreach (var item in queryOrderWithCustomer)
            {
                if (item.Customer != null)
                {
                    Console.WriteLine($"{item.Customer.ContactName} of {item.Customer.City} paid {item.Freight} for {item.ShipName}");
                }
            }

            var orderQueryUsingInnerJoin =
                from order in db.Orders
                where order.Freight > 750
                join customer in db.Customers on order.CustomerId equals customer.CustomerId
                select new { }
```

---

# JSON

- JavaScript Object Notation.
- Derived from JavaScript
- Used primarily to transmit structured data between a server and a web application.
- formatted in key value pairs (name-value pairs)
- Unlike HTML/XML focused on content less than formatting
- Used for Application Programme Interfaces.

JSON IS :- Lightweight, language independent, Human readable, Easily parsed (interpreted).

JSON Syntax format is based on two main structures:

- Objects: collection of name value pairs
- Array: ordered list of values

#### Example JSON object Syntax

```json
{
    "employeeID": 2983,
    "firstName": "Joe",
    "lastName": "Bloggs"
}
```

#### Example JSON array Syntax

```
{
    "employeeID": 2983,
    "firstName": "Joe",
    "lastName": "Bloggs"
    "courseStream": ["SDE", "DevOps", "DEV"]
}
```

An array of objects can also be created :)

---

## Introduction to XML

XML Is a human readable Markup language. It stands for **eXtensible Markup Langauge**

Separates information from presentation layer. It doesn't display data,  simply stores and transports data.

Standard created by W3C.

It's similar to JSON, it transports data from one program into another program

#### XML DECLARATION

```xml
<?XML>
<tag>Text</tag> //this is an element
```

#### naming rules

- elements are case sensitive
- element names must start with an underscore or letter
-  cannot start with xml, XML, or other variations of



#### XML Attributes

Attributes provide additional information about the element. They define properties of the element.

Attributes come as name-value pairs. value should be in quotes.