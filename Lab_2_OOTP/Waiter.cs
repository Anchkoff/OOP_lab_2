using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOTP
{
    [Serializable]
    public class Waiter : RestaurantWorker
    {
        public double Tips
        {
            get; set;
        }

        public Waiter() { }

        public Waiter(string name, string surname, DateTime dateOfBirth, string phone, Address address, double salary) : base(name, surname, dateOfBirth, phone, address, salary)
        {
            Tips = 0;
        }
    }
}
