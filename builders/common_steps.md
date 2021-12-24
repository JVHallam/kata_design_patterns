# Common Steps:
## Create the initial "User" model
* Create the User Model
    * Create the Models Directory
    * Create the "User" Model
        * string Name;
        * int Age;

* Create The printer class
    * Create the "Utility" Directory
    * Create the "Printer" class
        * Static void Print( User )
        * User : <Name> - Age : <Age>

* Back in main:
    * Create a user
        * Name : Jake
        * Age : 26

    * Print it

## Create the embedded Address model:
* Create the address model:
    * string PostCode
    * int HouseNumber

* Embed it into the User class
    * User.Address

* Extend the Printer class:
    * Print(Address)
        * Address : <house number> - PostCode : <post code>
    * Have it be called, when Print(User) is called

* Use it in main:
    * Update the created user, by setting
    * User.Address = new Address()
    * Set PostCode = "BS23"
    * Set HouseNumber = 1
