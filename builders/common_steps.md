# Common Steps:
## Create the initial "User" model

* Setting up the User Model
    * Create : Models Directory
    * Create : User Model
        * string Name;
        * int Age;

* Create The printer class
    * Create : "Utility" Directory
    * Create : "Printer" class
        * Static void Print( User )
        * Outputs: 
            * User : <Name> - Age : <Age>

* Back in main:
    * Create a user
        * Name : Jake
        * Age : 26

    * Print it

## Create the embedded Address model:
* Setting up the Address model:
    * Create : Address Model
        * string PostCode
        * int HouseNumber

* Embed it into the User class
    * Add to user, the member : Address

* Extend the Printer class:
    * Print(Address)
        * Address : <house number> - PostCode : <post code>
    * Have it be called, when Print(User) is called

* Use it in main:
    * Update the created user, by setting
    * User.Address = new Address()
    * Set PostCode = "BS23"
    * Set HouseNumber = 1
