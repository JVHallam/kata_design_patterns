using System;
using practise_area.Models;

namespace practise_area.Factories
{
    public static class UserFactory
    {
        private readonly static List<String> Names = new List<string>(){
            "Jake",
            "Jack",
            "Joe",
            "Harry",
            "Tom"
        };

        private readonly static Random _random = new Random();

        public static User Create()
        {
            return new User()
            {
                Name = Names[_random.Next(Names.Count)],
                Age = _random.Next(100),
                Address = AddressFactory.Create()
            };
        }
    }
}
