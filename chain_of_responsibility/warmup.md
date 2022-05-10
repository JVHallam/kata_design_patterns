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

* Part II: Capture Calc args into a request
    * Create /Requests
    * Create the MathRequest model
        * It's the args for the Calc.Calculate function
        * Properties -> First, Second, Op
        * Constructor(First, Second, Op)

    * Refactor the Calc.Calculate function to take those
    * Change program.cs to use those
    * Test you still get 4,0,1,4

* Part III: Refactor in the operators as their own types - reduce the length of the constructor down to 2 args
    * Create the request subtype:
        * Create the AddRequest
            * Make it inherit math request
            * Constructor(First, Second)
            * Pass those off to base

    * Test the subtype:
        * Use it in program.cs for the Add
        * test 4,0,1,4

    * Update the other subtypes:
        * Rinse and repeat for the other 3 operators

* Part IV: Move the math logic into the handler
    * Create /Handlers
    * Introduce the AddHandler 
        * double Calculate(MathRequest) 

    * Use it in the earlier function 

    * Rinse and repeat for all 4 operations

* Part V: Allow Handlers to choose if they handle the request
    * Add the CanHandle function to the Handlers
        * public bool CanHandle(MathRequest)
    * Use that to check if a handler can handle the request
    * Use that inside of calc.cs
        * Use a chain of if's - calling CanHandle
        * Don't use a switch statement

* Part VI: Chain them together
    * Create the /Handlers/MathChainHandler.cs

    * Methods:
        * abstract double Calculate
        * abstract bool CanHandle
        * double Handle(MathRequest req)
            * Calls can handle
            * If it can, call calculate
            * Else, call next
        * void SetNext(MathChainHandler next)
            * States who's next in the chain

    * Make all handlers inherit this
    * Get them to chain instead
    * Call handle on the first entry in the chain
    * Re-test, 4,0,1,4

* Part VII: Introduce the builder
    * Create /Builders
    * Create a ChainHandlerBuilder
    * Make it have:
        * ChainHandlerBuilder AddNext(HandlerBase)
        * MathChainHandler Build()

    * Use it in the Calc.cs function

* Part VIII: Introduce the factory:
    * In Program.cs:
        * Put all operators into an array
        * Foreach op in that array
        * do the math operation on 2 and 2
        * You'll need a factory for this

    * Create /Factories

    * Create a static RequestFactory
        * MathRequestBase Create(first, second, op)
        * Returns a request, base on the operator

    * Use this request factory in the main
