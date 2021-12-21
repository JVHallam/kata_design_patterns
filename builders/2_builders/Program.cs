using practise_area.Models;
using practise_area.Builders;
using practise_area.Utility;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var user = new UserBuilder()
                    .SetName("Jake")
                    .SetAge(26)
                    .HavingAddress(a => a
                            .SetZipCode("Test")
                            .SetHouseNumber(1)
                    )
                    .Build();

Printer.Print(user);
