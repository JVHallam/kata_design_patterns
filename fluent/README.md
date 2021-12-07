# Fluent APIS kata:
* Models
    * Setters
    * Getters
    * Syntax around these
    * Best practises

* Model Builders
    * With?
    * Embedded Builders
        * Having(a => a)?
        * Build all build
    * What are the naming conventions here?

* Factories
    * Model factories
    * Builder factories

* One more, Prototype?

* Then using all 4 together
    * Models
    * Created by builders
    * Created by factories
    * All to create a test case

----------------------------------------------------------

Prototype :
* Object.Clone()
* It's on the object that you want to clone
* I did use this, when i was branching test cases
    * Builder.Clone().SetAge()
* Could tie in with the builder pattern like i expected
* Allows for immutable code

* The usecase i've had for this, was creating exponentially branching test cases.
    * Builder.Clone().Set value, but in a SelectMany Statement, followed by another selectMany statement


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

## User Builder
* Create the user model
    * string Name
    * int Age

* Create the user Builder
    * SetName
    * SetAge
    * Build

* Use the builder in the main function, instead of a constructor

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
* Duplicating classes
* Use case : SelectMany with TestCases

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


