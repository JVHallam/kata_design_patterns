using System;
using practise_area.models;
using practise_area.builders;

namespace practise_area.factories
{
    public static class UserBuilderFactory
    {
        public static UserBuilder JakeBuilder()
        {
            return new UserBuilder()
                .SetName("Jake")
                .SetAge("15")
                .HavingAddress(a => a
                    .SetZipCode("123 123 123")
                )
                .HavingAddress(a => a
                    .SetZipCode("000 000 000")
                )
                .HavingAddress(a => a
                    .SetZipCode("111 111 111")
                );
        }
    }

    public static class UserFactory
    {
        public static User BuildJake(){
            return UserBuilderFactory.JakeBuilder().Build();
        }
    }
}
