using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOTP
{
    [Serializable]
    public class RestaurantWorker
    {
        public string Name
        {
            get; set;
        }
        public string Surname
        {
            get; set;
        }
        public DateTime DateOfBirth
        {
            get; set;
        }
        public string Phone
        {
            get; set;
        }
        public double Salary
        {
            get; set;
        }
        public Address Address
        {
            get; set;
        }

        public RestaurantWorker() { }

        public RestaurantWorker(string name, string surname, DateTime dateOfBirth, string phone, Address address, double salary)
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            Address = address;
            Salary = salary;
        }

    }
}
