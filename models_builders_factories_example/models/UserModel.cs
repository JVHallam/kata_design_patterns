using System;
using System.IO;
using System.Collections.Generic;

namespace practise_area.models
{
    public class User
    {
        public string Name;
        public string Age;
        public List<Address> Addresses;

        //This wouldn't normally be here
        public void EchoDetails()
        {
            Console.WriteLine($"Name : {Name}, Age : {Age}");
            foreach(var address in Addresses){
                address.EchoDetails();
            }
        }
    }
}
