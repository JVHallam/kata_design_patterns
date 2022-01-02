---
slug: "/builder-patterns/prototypes"
title: "Builder Pattern : Prototypes"
---

# Prototype - Building off of things
## Pre setup:
* dotnet new console

## Creating the base class
* Creating TestCase:
    * Create : Directory -> Models
    * Create : TestCase.cs
        * Members:
            * bool A;
            * bool B;
            * bool C;

* Creating Print Utility:
    * Create : Directory -> Utility
    * Create : Printer.cs
    * Method : Print(TestCase)
        * A : true, B : true, C : true

* Updating Main:
    * Create a test case:
        * Set : A = true
        * Set : B = false
        * Set : C = true

    * Print it

## Creating Broken permutations of all values

* Generate the test cases:
    * Foreach value ( True, False )
        * Set : A = each value
        * Set : B = each value
        * Set : C = each value

    * So that you get:
        * A = true, B = true, C = true
        * A = false, B = true, C = true
        * A = false, B = false, C = true
        * A = false, B = false, C = false
        * ...etc...
        * for all 8 outcomes

* Use Linq and lists, to do the above
    * Chain together Select statements to 
    * Cast IEnumerable to list

* Print:
    * Extend the Printer utility
        * Print(List<TestCase> testCases)

    * Print out all the values

    * Note that it should now be broken

# Fixing the issue with clone
* Duplicating the Class:
    * Extend TestCase
    * Add in "public TestCase Clone()"
    * Clone the class

* In the linq statements, use Clone when setting values

* Notice it now works
