# Factories - Replacing the Constructors

## Do common step - Create the user model

## Create a user factory:
* Create the factory:
    * Create : directory - "Factories" 
    * Create : static class - UserFactory 
    * Create : method - "Create"
        * Returns a new user:
            * Name = Jake
            * Age = 26
    
    * Use that in the main function

## Do common step - Create the Address model

## Create the address factory
* Address Factory
    * Create : static "AddressFactory" class
    * Create : "Create" Method
        * Return a new Address
        * HouseNumber = 1
        * PostCode = BS23

* User Factory:
    * Extend the user factory to call it
    * Automatically add the Address to the user

* Update Main:
    * Remove the manual setting of the address

## Randomise the values
* Randomising User values:
    * Edit the "UserFactory":
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
