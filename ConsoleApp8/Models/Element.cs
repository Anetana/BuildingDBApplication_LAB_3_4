using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Models
{
    public class Element
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(15, 2)")]
        public decimal VatRate { get; set; }

        public override string ToString()
        {
            return ("id: " + Id + " name: " + Name + " Price: " + Price + " VatRate:" + VatRate);
        }
    }
}
