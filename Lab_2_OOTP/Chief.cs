using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOTP
{
    class Chief: Cook
    {
        public bool SwearLikeGordon
        {
            get; set;
        }
        public string SignatureDish
        {
            get; set;
        }
        public Chief(string name, string surname, DateTime dateOfBirth, string phone, Address address, double salary, int category, bool swearLikeGordon, string signatureDish) : base(name, surname, dateOfBirth, phone, address, salary, category)
        {
            SwearLikeGordon = swearLikeGordon;
            SignatureDish = signatureDish;
        }
    }
}
