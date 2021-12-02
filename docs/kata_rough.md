# Builder

## Pre notes:
* This pattern requires 2 objects
    * The main object
    * The builder - for the object

## Result:
```C#
    var userBuilder = new UserBuilder();

    var user = userBuilder
        .SetName("Bob")
        .SetAge(50)
        .Build();

    # Echos "I am Bob and i am 50"
    user.WhoAmI();
```

```
using System;

namespace practise_area
{
    class UserBuilder
    {
        string _name;
        string _age;

        public UserBuilder(){

        }

        public UserBuilder SetName(string name){
            this._name = name; 
            return this;
        }

        public UserBuilder SetAge(string age){
            this._age = age; 
            return this;
        }

        public User Build()
        {
            return new User(this._name, this._age);
        }
    }

    class User
    {
        string Name{ get; set; }
        string Age{ get; set; }

        public User(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public void WhoAmI(){
            Console.WriteLine($"I Am {Name} and i am {Age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var builder = new UserBuilder();

            builder
                .SetName("Bob")
                .SetAge("50");

            var user = builder.Build();
            
            user.WhoAmI();
        }
    }
}

```

# This builder example, combines the immutability of functional with the builder pattern. And i Nutte'ed
```
using System;
using System.Linq;
using System.Collections.Generic;

namespace icloneable
{
    class Jake
    {
        public bool isCool;
        public bool isTall;

        public Jake(bool isCool, bool isTall)
        {
            this.isCool = isCool;
            this.isTall = isTall;
        }

        public string GetDetails(){
           return $"isCool : {isCool}, isTall : {isTall}";
        }
    }

    class JakeBuilder : ICloneable
    {
        public bool _isCool;
        public bool _isTall;

        public JakeBuilder(){

        }

        public object Clone(){
            return this.MemberwiseClone();
        }

        public JakeBuilder SetIsCool(bool isCool){
            var clone = (JakeBuilder)this.Clone();
            clone._isCool = isCool;
            return clone;
        }

        public JakeBuilder SetIsTall(bool isTall){
            var clone = (JakeBuilder)this.Clone();
            clone._isTall = isTall;
            return clone;
        }

        public Jake Build(){
            return new Jake(this._isCool, this._isTall);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<bool> BooleanOptions = new List<bool>{true, false};

            var JakeCases = BooleanOptions.Select(option => {
                return new JakeBuilder().SetIsCool(option);
            }).Select(builder => {
                return BooleanOptions.Select(option => {
                   return builder.SetIsTall(option);
                });
            }).SelectMany(x => x)
            .Select(x => x.Build());

            var a = new Jake(true, true);
            var b = new Jake(true, false);
            var c = new Jake(false, true);
            var d = new Jake(false, false);

            Console.WriteLine(a.GetDetails());
            Console.WriteLine(b.GetDetails());
            Console.WriteLine(c.GetDetails());
            Console.WriteLine(d.GetDetails());

            Console.WriteLine("========================");
            Console.WriteLine("Builder Jakes");

            var baseBuilder = new JakeBuilder();
            var coolBuilder = baseBuilder.SetIsCool(true);
            var tallBuilder = baseBuilder.SetIsTall(true);

            var baseJake = baseBuilder.Build();
            Console.WriteLine(baseJake.GetDetails());
            var coolJake = coolBuilder.Build();
            Console.WriteLine(coolJake.GetDetails());
            var tallJake = tallBuilder.Build();
            Console.WriteLine(tallJake.GetDetails());

            Console.WriteLine("========================");
            Console.WriteLine("Itterative Jakes");
            
            foreach(var jake in JakeCases){
                Console.WriteLine(jake.GetDetails());
            }

        }
    }
}

```

# If you want to use embedded builders. That's a builder inside a builder, so that you can chain them:

```C#
using System;

namespace practise_area
{
    class Details
    {
        public string name;
    }

    class DetailsBuilder
    {
        private string name;

        public DetailsBuilder()
        {
        }

        public DetailsBuilder SetName(string value)
        {
            this.name = value;
            return this;
        }

        public Details Build()
        {
            return new Details()
            {
                name = name
            };
        }
    }

    class UserBuilder
    {
        string _name;
        string _age;
        DetailsBuilder _details;

        public UserBuilder(){
           _details = new DetailsBuilder(); 
        }

        public UserBuilder SetName(string name){
            this._name = name; 
            return this;
        }

        public UserBuilder SetAge(string age){
            this._age = age; 
            return this;
        }

        public UserBuilder HavingDetails(Action<DetailsBuilder> callback)
        {
            callback(_details);
            return this;
        }

        public User Build()
        {
            var details = _details.Build();
            return new User(this._name, this._age, details);
        }
    }

    class User
    {
        string Name{ get; set; }
        string Age{ get; set; }
        Details About { get; set; }

        public User(string name, string age, Details about)
        {
            Name = name;
            Age = age;
            About = about;
        }

        public void WhoAmI(){
            Console.WriteLine($"I Am {Name} and i am {Age}");
            Console.WriteLine($"Details Name {About.name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var builder = new UserBuilder();

            builder
                .SetName("Bob")
                .SetAge("50")
                .HavingDetails(d => d
                        .SetName("Yes")
                        .SetName("No")
                        .SetName("Maybe")
                );

            var user = builder.Build();

            user.WhoAmI();
        }
    }
}
```
