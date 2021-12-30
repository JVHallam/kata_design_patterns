# THIS IS APPLICATION
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
