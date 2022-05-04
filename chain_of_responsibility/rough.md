# Practise
* What we do:
    * Inherritence
    * Abstract base classes

    * Implement these design patterns:
        * Chain of command
        * Builder Pattern
        * Factory method

# What you're doing:
* Part 0: Setup
    * Dotnet new console
    * Hello world
    * Create a calculator
        * Calc.Calculate static function
        * Takes 2 numbers
        * Takes an operator character
        * Does +, -, /, and *
    * Test the calculator
        * Do 2 + 2 => 4
        * Do 2 - 2 => 0
        * Do 2 / 2 => 1
        * Do 2 * 2 => 4

* Part I: Introduce requests 
    * Create /Requests
    * Create the AddRequest model - takes 2 ints
    * Overload calc to take requests too
    * Use it instead of the other + method

* Part II: Introduce more requests
    * Add subtract request
    * Extend Calculate Request
    * Implement the calc for subtract request
    * Introduce the MathRequest base class - It has the Properties instead
    * Have both requests now inherit that
    * Use it instead of the other - method

* Part III: Introduce the handlers
    * Create /Handlers
    * Introduce the AddHandler 
    * give it a Calculate(AddRequest) function
    * Use it in the earlier function

* Part IV: Abstract the handlers
    * Create an Abstract Base Class:
        * RequestHandler
        * RequestHandler:abstract double Calculate(MathRequestBase)
    * Add the SubtractHandler : RequestHandler
    * Use the subtract handler

* Part V: Finish the Calculate function:
    * Implement the Multipy and Division Requests
    * Implement the Multipy and Division Handlers
    * Condense Calc.cs to be one function:
        * Calculate(MathRequestBase request)
        * Switch based on the type
        * To the correct handler

* Part VI: Introduce the chain
    * Extend handler base:
        * HandleBase:abstract bool CanHandle(MathRequestBase)

    * Implement it in each handler:
        * Each handler checks if it's a type it can handle

    * Extend handler base more:
        * void RegisterNext(HandlerBase next)
            * Saves the next handler in the chain
        * public double Handle(MathRequestBase request)
            * This uses CanHandle to check if it can handle the request
            * It calls Calculate if it can
            * It calls the next in the chain if not

    * Use the chain implementation instead of the switch statement

* Part VII: Introduce the builder
    * Create /Builders
    * Create a HandlerChainBuilder
    * Make it have:
        * HandlerChainBuilder AddNext(HandlerBase)
        * HandlerBase Build()

    * Use it in the Calc.cs function

* Part VIII: Introduce the factory:
    * Create /Factories
    * Create a static RequestFactory
        * MathRequestBase Create(first, second, op)
        * Returns a request, base on the operator
    * Use this request factory in the main

* Part IX: Play with it
    * Introduce the DebugHandler
    * Create the IHandler interface
        * It has RegisterNext
        * Handle()
    * It just Console.WriteLines the request, then calls the next one - inside of Calc
    * Use it

* Part X: Redo this again
    * Either refactor this and condense it, or extend it to be longer?
    * Maybe implement an error handler to handle un-handled responses
