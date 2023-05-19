using ConsoleApp8.Data;
using ConsoleApp8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Repositories
{
    public class CustomerRepository
    {
        public static void Save(Customer customer)
        {
            using (MyDBContext context = new MyDBContext())
            {
                if(customer.Id != 0)
                {
                    context.Customers.Update(customer);
                }
                else
                {
                    context.Customers.Add(customer);
                }

                context.SaveChanges();
            }
        }

        public static List<Customer> GetAll()
        {
            using (MyDBContext context = new MyDBContext())
            {
                var customers = context.Customers.ToList();
                return customers;
            }
                
        }
    }
}
