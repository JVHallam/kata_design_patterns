using System;

namespace practise_area.Models
{
    public class TestCase
    {
        public bool A;
        public bool B;
        public bool C;

        public TestCase Clone()
        {
            return (TestCase)this.MemberwiseClone();
        }
    }
}
