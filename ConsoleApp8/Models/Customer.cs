using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public Int16? IsCompany { get; set; }
        public string? TaxIdentificationNumber { get; set; }

        public override string ToString()
        {
            return ("id: " + Id + " name: " + Name + " Country: " + Country + " IsCompany:" + IsCompany
                    + "TaxIdentificationNumber: " + TaxIdentificationNumber);
        }

    }
}
