# Fluent APIS kata:

----------------------------------------------------------

# Models
## Creating a base model
* Create the "User" Model
    * Create a new directory - models
    * Create "User" model
        * string - Name;
        * int  - Age;

* Create a printer function:
    * Create "Utility" Directory
    * Create static Printer class
    * Create static Print(User) method
        * Echo: User - <name>, Age - <Age>

* Use it in the program
    * Create a user, jake, 26
    * Print it

## Create an embedded model
* Create and embed the new model:
    * Create a new model - Address
        * string ZipCode
        * int House number

    * Extend the User Class:
        * member: Address Address;

* Extend the print function:
    * Extend the print function to print the address
        * ZipCode : <ZipCode> - HouseNumber : <HouseNumber>

* Use it in main:
    * Add a the address to the user
        * ZipCode : BS23
        * HouseNumber : 1

    * Print the user and it's address

## Constructors - Replace the initialisation
* User Constructor:
    * Add a constructor to the user
    * Have it take the args:
        * name 
        * age 
        * house number
        * zipCode

    * Have it setup it's address
        
* Updating Main:
    * Use the constructor
    * Print the result

----------------------------------------------------------

# Builder - Replacing the Constructors
* Why? : Don't put constructors in your model yo, it makes the code base a little harder to read.

## User and UserBuilder
* User Model:
    * Create the Models directory 

    * Create the model : User
        * string Name;
        * int Age;

* User Builder:
    * Create the "Builders" Directory 

    * Create the UserBuilder
        * Each method should "return this;"
        * Methods:
            * SetName
            * SetAge
            * Build - Returns a new User

* Test it:
    * In the program.cs
    * Use the builder to create a user
        * Name - Jake
        * Age - 26
    * Build the user
    * Print the output user
        * User - Jake, Age : 26

## Embedded Builders
* Address Model:
    * Create the address model
        * string ZipCode
        * int HouseNumber

    * Embed it into the User Model:
        * User.Address 

* Builder Setup:
    * Create the address builder
        * Each builder method "return this;"
            * SetZipCode
            * SetHouseNumber

        * Build - Returns an address

    * Embed the address builder in the user builder
        * AddressBuilder.UserBuilder

    * Extend UserBuilder:
        * Give it the "WithAddress" function
        * User.WithAddress(a => a.Set() );

    * Call address.Build() inside of user.Build()

* Back in the main function:
    * Extend the print function to print the address
        * HouseNumber : 1, ZipCode : BS20
    * Use the "HavingAddress" to set :
        * houseNumber to 1 
        * ZipCode to BS20

----------------------------------------------------------

# Factories - Replacing the Constructors

## Do common step - Create the user model

## Create a user factory:
* Create the factory:
    * Create the "factory" directory
    * Create the static UserFactory class
    * Create the "Create" method
        * Returns a new user:
            * Name = Jake
            * Age = 26
    
    * Use that in the main function

## Do common step - Create the Address model

## Create the address factory
* Address Factory
    * Create the static "AddressFactory" class
    * Create the "Create" Method
        * Return a new Address
        * HouseNumber = 1
        * PostCode = BS23

* Extend the user factory to call it

* Main should Now print a user with an address

## Randomise the values
* Randomising User values:
    * edit the "UserFactory":
        * Take the list for names:
            * Jake
            * Jack
            * Joe
            * Harry
            * Tom

        * Use Random to select which one to use

        * User.Age:
            * Randomly pick an int between 0 and 100

* Randomising the Address values:
    * Address.PostCode
        * Generate the string "SO" + random int between 0 and 10

    * Address.HouseNumber:
        * An int between 0 and 100

* Update Main:
    * Generate 5 users
    * Print them
    * Note the random differences

----------------------------------------------------------

# Prototype - Building off of things
## Creating the base class
* Creating TestCase:
    * Create : Directory -> Models
    * Create : TestCase.cs
        * Members:
            * bool A;
            * bool B;
            * bool C;
            * bool D;

* Creating Print Utility:
    * Create : Directory -> Utility
    * Create : Printer.cs
    * Method : Print(TestCase)
        * A : true, B : true, C : true, D : true

* Updating Main:
    * Create a test case:
        * A : true
        * B : false
        * C : true

    * Print it

## Creating Broken permutations of all values
* Generate the test cases:
    * Foreach member ( A, B, C )
        * Foreach possible values ( True, False )
            * Create a TestCase

* Use Linq and lists, to do the above
    * Chain together Select statements to 
    * Cast IEnumerable to list

* Print:
    * Go through the list twice
    * Print out all the values
    * Notice, It's broken.

# Fixing the issue with clone
* Duplicating the Class:
    * Extend TestCase
    * Add in "public TestCase Clone()"
    * Clone the class

* In the linq statements, use Clone when setting values

* Notice it now works

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
