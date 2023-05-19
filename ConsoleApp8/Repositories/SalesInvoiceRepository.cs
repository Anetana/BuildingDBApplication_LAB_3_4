using ConsoleApp8.Data;
using ConsoleApp8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Repositories
{
    public class SalesInvoiceRepository
    {
        public static void Save(SalesInvoice salesInvoice)
        {
            using (MyDBContext context = new MyDBContext())
            {
                if (salesInvoice.Id != 0)
                {
                    context.SalesInvoices.Update(salesInvoice);
                }
                else
                {
                    context.SalesInvoices.Add(salesInvoice);
                }

                context.SaveChanges();
            }
        }

        public static List<SalesInvoice> GetAll()
        {
            using (MyDBContext context = new MyDBContext())
            {
                var salesInvoices = context.SalesInvoices.ToList();
                return salesInvoices;
            }

        }
    }
}
