using System;
using practise_area.models;

namespace practise_area.builders
{
    public class AddressBuilder
    {
        private Address address;

        public AddressBuilder()
        {
            address = new Address();
        }

        public AddressBuilder SetZipCode(string value)
        {
            this.address.ZipCode = value;
            return this;
        }

        public Address Build()
        {
            return address;
        }
    }
}
