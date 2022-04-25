# Quick idea:
* A base class with some base functionality and state
    * Focus on just building this class with some weird shit in it
    * This class could be focused on handling requests or statemanagement

* A builder for building the above class' state
    * Just a builder

* A Proxy, to call off to the builder at a later date
    * I don't know what i'm doing here, lol

* A Memento for storing the state
    * Have a method for getting the state in an encapsulated class
    * Have a method for setting that state
    * It's be cool to tie this all together by passing the memento to the proxy's constructor
    * The builder could then unpack that - as part of the constructor
    * Then the builder could be called when the proxy is used
    * Then the class would just exist
