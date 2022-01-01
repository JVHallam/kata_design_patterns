using System;
using practise_area.Models;

namespace practise_area.Builders;

public class AddressBuilder
{
    private readonly Address _address;

    public AddressBuilder()
    {
        _address = new Address();
    }

    public AddressBuilder SetHouseNumber(int value)
    {
        _address.HouseNumber = value;
        return this;
    }

    public AddressBuilder SetPostCode(string value)
    {
        _address.PostCode = value;
        return this;
    }

    public Address Build()
    {
        return new Address()
        {
            PostCode = _address.PostCode,
            HouseNumber = _address.HouseNumber
        };
    }
}
