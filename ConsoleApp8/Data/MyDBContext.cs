using ConsoleApp8.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp8.Data
{
    public class MyDBContext : DbContext
    {
        
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Element> Elements { get; set; }
            public DbSet<SalesInvoice> SalesInvoices { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source=; Initial Catalog = BD_Base; User ID = Anna; Password =; TrustServerCertificate = true"); ;
            }
        }
    }
