using System;

namespace practise_area.Models
{
    public class User
    {
        public string Name;
        public int Age; 
        public Address Address;

        public User(string name, int age, int houseNumber, string zipCode)
        {
            Name = name;
            Age = age;
            Address = new Address()
            {
                ZipCode = zipCode,
                HouseNumber = houseNumber
            };
        }
    }
}
