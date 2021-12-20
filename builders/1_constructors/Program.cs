using System;
using practise_area.models;

namespace practise_area
{
    class Program
    {
        public static void PrintAddress(Address address)
        {
            Console.WriteLine($"ZipCode - {address.ZipCode}, HouseNumber - {address.HouseNumber}");
        }
        public static void PrintUser(User user)
        {
            Console.WriteLine($"User : {user.Name} - Age : {user.Age}");
            PrintAddress(user.Address);
        }

        static void Main(string[] args)
        {
            var user = new User("Jake", 25, 1, "BS238DA");

            PrintUser(user);
        }
    }
}
