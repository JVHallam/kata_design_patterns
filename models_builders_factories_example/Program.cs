using System;
using practise_area.models;
using practise_area.builders;
using practise_area.factories;

namespace practise_area
{
    class Program
    {
        static void Main(string[] args)
        {
            var jake = UserFactory.BuildJake();
            jake.EchoDetails();

            var luxuriousJakeBuilder = UserBuilderFactory.JakeBuilder();
            var luxuriousJake = luxuriousJakeBuilder
                .SetAge("40")
                .HavingAddress(a => a
                    .SetZipCode("420 420 420")
                )
                .HavingAddress(a => a
                    .SetZipCode("690 690 690")
                )
                .Build();
            luxuriousJake.EchoDetails();
        }
    }
}
