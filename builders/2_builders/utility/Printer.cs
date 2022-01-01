using System;
using practise_area.Models;

namespace practise_area.Utility;

public static class Printer
{
    public static void Print(Address address)
    {
        Console.WriteLine($"Address : {address.HouseNumber}, PostCode : {address.PostCode}");
    }

    public static void Print(User user)
    {
        Console.WriteLine($"User : {user.Name}, Age : {user.Age}");
        Print(user.Address);
    }
}
