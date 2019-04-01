using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOTP
{
    [Serializable]
    public class Manager: RestaurantWorker
    {
        public int Suborditates
        {
            get; set;
        }

        public Manager() { }

        public Manager(string name, string surname, DateTime dateOfBirth, string phone, Address address, double salary, int subordinares) : base(name, surname, dateOfBirth, phone, address, salary)
        {
            Suborditates = subordinares;
        }
    }
}
