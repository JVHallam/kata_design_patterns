using System;
using practise_area.Models;

namespace practise_area.Builders
{
    public class AddressBuilder
    {
        private readonly Address _address;

        public AddressBuilder()
        {
            _address = new Address();
        }

        public AddressBuilder SetZipCode(string value)
        {
            _address.ZipCode = value;
            return this;
        }

        public AddressBuilder SetHouseNumber(int value)
        {
            _address.HouseNumber = value;
            return this; 
        }

        public Address Build()
        {
            return _address;
        }
    }
}
