using System;
using practise_area.Models;

namespace practise_area.Builders;

public class UserBuilder
{
    private readonly User _user;
    private readonly AddressBuilder _addressBuilder;

    public UserBuilder()
    {
        _user = new User(); 
        _addressBuilder = new AddressBuilder();
    }

    public UserBuilder SetName(string value)
    {
        _user.Name = value;
        return this;
    }

    public UserBuilder SetAge(int value)
    {
        _user.Age = value;
        return this;
    }

    public UserBuilder HavingAddress(Action<AddressBuilder> callback)
    {
        callback(_addressBuilder);
        return this;
    }

    public User Build()
    {
        return new User()
        {
            Name = _user.Name,
            Age = _user.Age,
            Address = _addressBuilder.Build()
        };
    }
}
