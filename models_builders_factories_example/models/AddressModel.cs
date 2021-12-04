using System;
using System.IO;

namespace practise_area.models
{
    public class Address
    {
        public string ZipCode;
    
        public void EchoDetails()
        {
            Console.WriteLine($"Address - Zipcode : {ZipCode}");
        }
    }
}
