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

* Request:  
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
