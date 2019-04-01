using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOTP
{
    [Serializable]
    public class Address
    {
        public string City
        {
            get; set;
        }
        public string Street
        {
            get; set;
        }
        public int Building
        {
            get; set;
        }
        public int Flat
        {
            get; set;
        }
        public Address() { }
        public Address(string city, string street, int building)
        {
            City = city;
            Street = street;
            Building = building;
        }
        public Address(string city, string street, int building, int flat)
        {
            City = city;
            Street = street;
            Building = building;
            Flat = flat;
        }
    }
}
