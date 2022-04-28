# Implemented design patterns:
* In chain of command section:
    * Chain of command
    * Builder
    * Factory

# Suggestion:
* A base class / base implementation
* A creation pattern
* A structural pattern
* A behavioural pattern
    * You create a base, via the creation pattern, then something else, then the behavioural pattern kicks in
    * You should really build these katas from Behavioural downward, but learn them from base upward
* The hello world for each of the above get put into my warm ups

-----------------------------------------------------

# Factories:
* Factory pattern
* Inheritance and base classes

# Design pattern that kinda make sense
* Decorator -> Sounds cool
    * You create a class that inherits your base class
    * When you create an instance of the subclass, you pass an instance of the base class to that class
    * All calls to the subclass are redirected to the passed in class
    * It's so that you can extend a base classes functionality in a customizable and combinable and dynamic way
    * It's pretty cool

* Proxy -> it's like lazy evaluation for big objects
    * A text document -> An Images' proxy -> An Image
    * The image isn't instantiated until proxy is invoked
    * Proxy has the same interface as the Image class, forwards all requests to the image, but doesn't
      create the image until the first call.

* Command -> It's wrapping up a list of calls to a receiver, in a class called command
    * Command takes a receiver
    * Command.Execute() is called
    * Command does things to the receiver

* Singleton -> This could be interesting
    * You have a class that has a static member
    * Class.GetInstance() returns the one instance
    * The returned instance is not static, it is however, something that can be gotten from anywhere

* Observer - It's a pub/sub event driven thing
    * Subject - the class you can subscribe to
    * Observer - the class that subscribes
    * Subject.Subscribe(Observer) - subscribe
    * Subject.Publish(value) - sends values to all the subscribers

* Mediator - Detached classes interact via a third class
    * You have class A - Broker
    * You have class B - Stock exchange - this is our mediator
    * broker = new Broker(StockExchange);
    * broker2 = new Broker(StockExchange);
    * broker.sellOffer(1) -> broker passes that into stock exchange - the mediator class
    * broker.buyOffer(1) -> broker passes that into stock exchange

* Memento - Save the state of an object, so it can be restored later
    * Memento - stores the state
    * Originator - passes state into the mementor
    * Caretaker - Saves the mementos
    * Would be useful if you wanted to undo operations

* State - Change behaviour based on state
    * You have a base class - an ATM
    * You have a state class - ATM State
    * You inherit from state - to create a bunch of other states
    * General functionality is held inside of the base class
    * Any functionality that would change based on state, is stored in your state classes
    * It's a fucking wild pattern, it's more of a UI pattern

------------------------------------------------

* Abstract Factory:
    * This is for grouping together a bunch of other factories into one
    * You call CarBrokerFactory.CreateCar("Sports")
    * if type == "Sports" -> MazdaFactory.CreateMx5()
    * if type == "Family" -> NissanFactory.CreateLeaf()
    * Kinda boring imo

* Iterator/cursor - It's a class that allows you to move through a list, and keeps track of where you are and what's next for you.
  * Could be useful for iterating over elements in a graph

* Composite -> When an object and the objects it's composed of, have the same interface

* Interpretter -> ?
    * It's for converting values from one to another?
    * Quart class -> interpretter converts it to pints?

* Visitor :
    * This is just extension methods, but without being extensions
    * Basically feels like it doesn't really add much if it's not the above

* Bridge -> Have the interface and object be able to change independantly?!
    * 2 layers of abstraction
    * Not super crazy, just using interfaces

# Behvaiour Design patterns I have no idea about
* Strategy - A bunch of algorithms all together, acting as one

# Structural Design patterns i have no idea about
* Adapter -> Wrapper to adapt one interface to another
* Facade - Joining all small interfaces in a system, into one big interface
* Flyweight - Tiny objects
