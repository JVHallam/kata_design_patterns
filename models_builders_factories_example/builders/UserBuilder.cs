using System;
using System.Collections.Generic;
using System.Linq;
using practise_area.models;

namespace practise_area.builders
{
    public class UserBuilder
    {
        private User user;
        private List<AddressBuilder> addressBuilders;

        public UserBuilder()
        {
            user = new User();    
            addressBuilders = new List<AddressBuilder>();
        }

        //Having
        public UserBuilder HavingAddress(Action<AddressBuilder> callback)
        {
            var addressBuilder = new AddressBuilder();
            callback(addressBuilder);
            this.addressBuilders.Add(addressBuilder);
            return this; 
        }

        //Sets
        public UserBuilder SetName(string value){
            this.user.Name = value;
            return this;
        }
        
        public UserBuilder SetAge(string value){
            this.user.Age = value;
            return this;
        }

        public User Build(){
            //Not a real function
            var addresses = addressBuilders.Select(ab => ab.Build()).ToList();

            this.user.Addresses = addresses;
            return this.user;
        }
    }
}
