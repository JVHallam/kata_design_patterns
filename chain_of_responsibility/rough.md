# Practise
* What we do:
    * Inherritence
    * Chain of command
    * Builder Pattern
    * Factory method

* Folder structure:
    * /Requests
        * /interfaces
    * /Handlers
        * /interfaces
    * /Factories
    * /Builders

* Basically, a calculator

* IRequest
    * 2 numbers as properties

* Request:   - IS this 
    * AddRequest : IRequest
    * SubtractRequest : IRequest

* IHandler:
    * Handle(IRequest)
    * RegisterNext
    
* Handlers:
    * AddHandler : IHandler
    * SubtractHandler : IHandler
    * DebugHandler : IHandler -> prints out the request and calls next

* Chain em

* Have Something compose them. Builder?
    * ChainBuilder.AddHandler(IHandler)
    * Build() => Registers them all into a chain, then returns the head of the queue

* Factory Method:
    * Instead of creating the requests have a method that takes
    * int number, int number, char operation
    * operation -> +, -, /, *
    * returns one of the classes

# More indepth
* Models:
    * Inherritance 
    * Interfaces
    * Base Classes 
    * Etc.

* Factories
    * Abstract
    * Other
    * Steal the stuff from before

* Builders
    * Steal the builder stuff from before

* Chain Of Command
    * Idk tbh
    * Maybe composite too lol

# What you're doing:
* Patterns used here:
    * Chain Of Responsibility
    * Builder
    * Factory

* Part I: Introduce requests 
    * Create /Requests
    * Create the AddRequest model
    * Create a Calc.Calculate static function
        * Calculate the result
        * Return it
        * Print it in the request
        * Print the final result in main

* Part II: Introduce more requests
    * Add subtract request
    * Introduce the MathRequest base class
    * Extend Calculate Request
    * Use a switch
    * Begin using a method for each type

* Part III: Introduce the handlers
    * Create /Handlers
    * Introduce the IHandler interface
        * int Handle(MathRequest req)
    * Introduce the AddHandler - not static
    * Introduce the SubtractHandler - not static
    * Have them be called in the switch, to handle their

* Part IV: Introduce the chain
    * Add RegisterNext(IHandler handler) to the interface
    * Each handler now takes a MathRequest in handle, not their subsequent things
    * If they can handle, they do, if not, they call next

* Part V: Introduce the error handling
    * Create the NotImplementedHandler - throws an exception if it's reached
    * Put this at the end of the chain
    * Introduce the DivisionRequest - but only the request
    * Call with this request
    * See it throws and exception as expected

* Part VI: Introduce the ChainBuilder
    * create /Builders
    * Create the chain builder class
    * have it have an AddNextHandler(IHandler) function
    * build hooks them all up and returns the first
    * Use this instead

* Part VII: 
    * create /Factories
    * Introduce the RequestFactory
    * Use it instead of the others
    * Make it unable to take operators not implemented
    * Should still take div, and div make the chain shit it's pants

* Part VIII:
    * Refactor and find something else to pad this out to eight entries
    * Handler abstract base class?
        * move RegisterNext here
        * move Handle - calls off to CalcAndPrint if the type is right
        * CalcAndPrint - Abstract - should be implemented by the inherriting class

    * Debug Handler - that takes the above and just prints the type and the args
    * Add that to the chain
