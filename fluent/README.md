# Fluent APIS kata:

----------------------------------------------------------

# Models
## Creating a base model
* Create a new directory - models
* Create a new model 
    * User
        * string name;
        * int age;

* Use it in the program
    * Create a user, jake, 26
    * Create a function to echo:
        * User, Name : <name>, Age : <Age>

## Create an embedded model
* Create a new model - Address
    * string ZipCode
    * int House number

* Embedded model 2 into user
    * User.Address

* Extend the print function to print the address
    * Console.WriteLine($"ZipCode : {user.Address.ZipCode}, HouseNumber : {user.Address.HouseNumber}");

* Extend main to give the user an address

## Constructors - Use them to replace the by hand shiz.
* Constructors
    * Make the constructor New up the address
    * Make the contructor take all 4 values for the user and the address

* Main
    * Re-write it to use the constructor

----------------------------------------------------------

# Builder - Replacing the Constructors
* Don't put constructors in your model yo, it makes the code base a little harder to read.

## Models:
* User
    * string Name;
    * int Age;
    * Address Address;

* Address:
    * string ZipCode;
    * int HouseNumber;

## User Builder
* Create the user Builder
    * SetName
    * SetAge
    * Build

* Use the builder in the main function, instead of a constructor

* Print it

## Embedded Builders
* Create the address model
    * string ZipCode
    * int HouseNumber

* Create the address builder
    * SetZipCode
    * SetHouseNumber
    * Build

* Embed the address builder in the user builder

* Give it the WithAddress function
    * User.WithAddress(a => a.Set() );

* Call address.Build() inside of user.Build()

* Create and echo

----------------------------------------------------------

# Factories - Replacing the Constructors

## Create the models:
* User
    * string name
    * int age
    * Address address

* Address
    * string PostCode
    * int houseNumber

* Same models and structure as before
* No constructors
* Print function

## Create a base factory
* Create factory directory
* Create a UserFactory.CreateUser()
* Make it static
* Return a new instance of the class
    * Name, jake
    * Age, 26
    * Address
        * PostCode Here
        * HouseNumber 21

* Use it in the main function
* Print it

# Random values
* With random values
* User.Name:
   * Create an array of a few names
   * Get one at random

* User.Age:
    * An int between 0 and 100

    * Address:
        * Address.PostCode
            * SO + a number between 0 and 10
        * Address.HouseNumber:
            * An int between 0 and 100

* Create a few 
* Print them

----------------------------------------------------------

# Prototype - Building off of things
* Create a testCase class
    * bool A;
    * bool B;
    * bool C;
    * bool D;

* Create a print function for this in main:
    * prints : A : true, B : true, C : true, D : true

* Create a testCase Builder class
    * A set for each of the above
    * A build

* Use the builder to create and print one:
    * A : true
    * B : false
    * C : true
    * D : false

# Creating permutations of all values

* Foreach field in the test case
    * Foreach possible value
        * Create a new test case builder
        * Put it into the list of test case builders

* Use Linq and lists, to do the above
    * Chain together select statements to 
    * IEnumerable will cause the code to work, when it should break. 
    * Case IEnumerable to list, we need to force evaluation

* Build them all

* Make sure the test cases List has been forced to evaluate before printing

* Print them all

* Notice that they're all more or less the same.

# Fixing the issue with clone
* Duplicating classes
    * Add a clone function to the builder
    * public TestCaseBuilder Clone()

* In the linq statements, use Clone when setting values

----------------------------------------------------------

# NOT KATA - THIS IS APPLICATION
* I want to use the:
    * Models
    * Builder
    * Factory
    * Prototype

* Have a test case model
* Have a builder for it
* Have a factory that builder with random data
* Make the builder a prototype
* Create branching scenarios, of of that base piece of data
    * Foreach value in 1..10, UserBuilder.WithAddress(a => a.SetHouseNumber(value));

