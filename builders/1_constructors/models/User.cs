using System;

namespace practise_area.models
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

            this.Address = new Address();

            Address.HouseNumber = houseNumber;
            Address.ZipCode = zipCode;
        }
    }
}
