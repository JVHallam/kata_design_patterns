# Builder - Replacing the Constructors
* Why? : Don't put constructors in your model yo, it makes the code base a little harder to read.

## Common Step : Create the initial "User" model
## Create the UserBuilder
* User Builder:
    * Create the "Builders" Directory 

    * Create the UserBuilder
        * Each builder method "return this;"
            * SetName
            * SetAge

        * Build - Returns a new user

* Test it:
    * In the program.cs
    * Use the builder to create a user
        * Name - Jake
        * Age - 26
    * Build the user
    * Print the output user
        * User - Jake, Age : 26

## Common Step : Create the embedded Address model:
## Embedded AddressBuilder
* Builder Setup:
    * Create the AddressBuilder
        * Each builder method "return this;"
            * SetZipCode
            * SetHouseNumber

        * Build - Returns a new address

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

## Using a Builder to it's fullest
* Creating a family
    * Create Dad 
        * Name : Joseph
        * Age : 50
        * Address:
            * HouseNumber : 45
            * PostCode : LONDON

    * Update the builder - To create the mom 
        * Name : Justine
        * Age : 45

    * Update the builder - To create the son 
        * Name : John
        * Age : 13

    * Update the builder - To create the daughter 
        * Name : Abby
        * Age : 20

* Print them all
    * Check their addresses are all the same
