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
