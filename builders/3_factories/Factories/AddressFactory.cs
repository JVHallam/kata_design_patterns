using System;
using practise_area.Models;

namespace practise_area.Factories
{
    public static class AddressFactory
    {
        public static Random _random = new Random();

        public static Address Create()
        {
            return new Address()
            {
                HouseNumber = _random.Next(100),
                PostCode = $"SO{_random.Next(10)}"
            };
        }
    }
}
