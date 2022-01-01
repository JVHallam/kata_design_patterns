using practise_area.Models;
using practise_area.Utility;
using practise_area.Builders;

var baseBuilder = new UserBuilder()
                    .HavingAddress(a => a
                            .SetHouseNumber(45)
                            .SetPostCode("LONDON")
                    );

var father = baseBuilder
                    .SetName("Joseph")
                    .SetAge(50)
                    .Build();

var son = baseBuilder
                    .SetName("John")
                    .SetAge(13)
                    .Build();

var mom = baseBuilder
                    .SetName("Justine")
                    .SetAge(45)
                    .Build();

var daughter = baseBuilder
                    .SetName("Abby")
                    .SetAge(20)
                    .Build();


Printer.Print(father);
Printer.Print(son);
Printer.Print(mom);
Printer.Print(daughter);
