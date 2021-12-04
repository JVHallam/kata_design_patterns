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

Abstract Factory:
* Abstract factory uses factories

* Factory -> A Method
* Abstract Factory -> Object

* Abstract factory is just an interface, for factory classes

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
    * ZipCode
    * House number

* Embedded model 2 into user
    * User.Address

* Rinse and repeat the above

## Constructors - Use them to replace the by hand shiz.
* Constructors

# Factories - Replacing the Constructors

# Builder - Replacing the Constructors

# Prototype - Building off of things
