# Practise
* What we do:
    * Inherritence
    * Abstract base classes

    * Implement these design patterns:
        * Chain of command
        * Builder Pattern
        * Factory method

# What you're doing:
* Part I: Setup the scenario
    * Dotnet new console
    * Hello world
    * Create a calculator
        * /calculator
            * calc.cs
        * Calc.Calculate static function
        * Takes 2 numbers
        * Takes an operator character
        * Does +, -, /, and *
    * Test the calculator
        * Do 2 + 2 => 4
        * Do 2 - 2 => 0
        * Do 2 / 2 => 1
        * Do 2 * 2 => 4

* Part II: Capture First and second into a request
    * Create /Requests
    * Create the MathRequest model
        * Put first and second into it as properties
    * Refactor the Calc.Calculate function to take those
    * Change program.cs to use those
    * Test you still get 4,0,1,4

* Part III: Refactor in the operators as types
    * Create the AddRequest
    * Use it in program.cs for the add
    * in the calc.cs - check if the type is add, if so, do add
        * Else, check the operator
    * test 4,0,1,4
    * Rinse and repeat for the other 3 operators
    * Remove operator as an arg to calc.Calculate
        * It's now just calc.Calculate(MathRequest request);

* Part IV: Move the math logic into the handler
    * Create /Handlers
    * Introduce the MathHandler
    * Introduce the AddHandler 
    * give it a Calculate(AddRequest) function
    * Use it in the earlier function
    * Rinse and repeat for all 4 operations

* Part V: Allow Handlers to choose if they handle the request
    * Add the CanHandle function to the Handlers
        * public bool CanHandle(MathRequest)
    * Use that to check if a handler can handle the request
    * Use that inside of calc.cs
        * Don't use a switch statement, use a CHAIN of if statements

* Part VI: Chain them together
    * Create the /Handlers/MathChainHandler.cs
    * Methods:
        * abstract double Calculate
        * abstract bool CanHandle
        * double Handle(MathRequest req)
            * Calls can handle
            * If it can, call calculate
            * Else, don't 
        * void RegisterNext(MathChainHandler next)
            * States who's next in the chain
    * Make all handlers inherit this
    * Get them to chain instead
    * Call handle on the first entry in the chain
    * Re-test, 4,0,1,4

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
