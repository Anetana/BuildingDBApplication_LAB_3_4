using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Models
{
    public class SalesInvoice
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string? DocumentNumber { get; set; }
        public List<Element> Elements { get; set; } = null!;
        public Customer customer { get; set; } = null!;

        public override string ToString()
        {
            return ("id: " + Id + " Created Date: " + CreatedDate 
                    + " Document Number: " + DocumentNumber);
        }
    }
}
