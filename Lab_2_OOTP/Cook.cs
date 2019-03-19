using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOTP
{
    class Cook: RestaurantWorker
    {
        public int Category
        {
            get; set;
        }

        public Cook(string name, string surname, DateTime dateOfBirth, string phone, Address address, double salary, int category)
            : base(name, surname, dateOfBirth, phone, address, salary)
        {
            Category = category;
        }
    }
}
