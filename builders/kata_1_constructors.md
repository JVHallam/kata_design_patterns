---
slug: "/builder-patterns/constructors"
title: "Builder Pattern : Constructor"
---

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
