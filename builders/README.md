# Fluent APIS kata:

----------------------------------------------------------

# Models
## Creating a base model
* Create a new directory - models
* Create "User" model
    * string - Name;
    * int  - Age;

* Create a printer function:
    * Create Directory Utility
    * Create Printer class
    * Create Print(User) method
        * Echo: User - <name>, Age - <Age>

* Use it in the program
    * Create a user, jake, 26
    * Print it

## Create an embedded model
* Create a new model - Address
    * string ZipCode
    * int House number

* Embedded model 2 into user
    * User.Address

* Extend the print function to print the address
    * Console.WriteLine($"ZipCode : {user.Address.ZipCode}, HouseNumber : {user.Address.HouseNumber}");

* Extend main to give the user an address

## Constructors - Use them to replace things
* User Constructor
    * Make it take 4 args, 
        * name 
        * age 
        * house number
        * zipCode

    * Make it new up the address too

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
    * string Name
    * int Age
    * Address Address

* Address
    * string PostCode
    * int HouseNumber

* Same models and structure as before
* No constructors
* Create an instance of both in the main function
* Print function
* Print them

## Create a base factory
* Create factory directory
* Create a static class UserFactory
* Create UserFactory.Create()
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
* User.Name:
    * Take this list of names
        * Jake
        * Jack
        * Joe
        * Harry
        * Tom

    * Now use Random to select which one to use

* User.Age:
    * Randomly pick an int between 0 and 100

* User.Address:
    * Address.PostCode
        * Generate the string "SO" + random int between 0 and 10

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

* Essentially:
    * Factory -> Generates a Builder with random data -> Populates a model
    * Builder -> To be copyable -> to create similar copies
    * You'd have a complex model
    * You'd want to only change 3 values out of 10
    * You'd generate a base builder, then change the 3 values, you'd clone it there, then you'd use it
    * You'd also do selectMany again here

    * You'd also want a function that you're testing with the data. Just make it print for now

# My Lousy attempt at the application:
## Create the base model
* User:
    * name
    * age
    * postCode
    * List<string> Allergy
        * Is this what i want to test permutations to?

* builder:
    * SetName
    * SetAge
    * SetPostCode
    * AddAllergy

* Factory:
    * Random Name
    * Random Age
    * Random PostCode
    * No Allergies

* Prototype:
    * Allow the User to be duplicated

* Then put them all through the function
