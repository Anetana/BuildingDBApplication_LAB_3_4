using ConsoleApp8.Models;
using ConsoleApp8.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Driver
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                Name = "Olkesiy",
                Country = "Ukraine",
                IsCompany = 7,
                TaxIdentificationNumber = "3415343"
            };

            CustomerRepository.Save(customer1);



            Element apple = new Element
            {
                Name = "Apple",
                Quantity = 10,
                Price = 4.2M,
                VatRate = 17
            };

            Element blackberry = new Element
            {
                Name = "BlackBerry",
                Quantity = 89,
                Price = 1.3M,
                VatRate = 43
            };

            ElementRepository.Save(apple);
            ElementRepository.Save(blackberry);



            SalesInvoice salesInvoice1 = new SalesInvoice
            {
                CreatedDate = DateTime.Now,
                DocumentNumber = "663487561",
                Elements = new List<Element> { apple, blackberry },
                customer = customer1,
            };

            SalesInvoiceRepository.Save(salesInvoice1);
            Console.WriteLine("Sales Invoice succesfully saved");





            var customers = CustomerRepository.GetAll();
            Console.WriteLine("List of all customers: ");
            foreach(var customer in customers)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine();


            var elements = ElementRepository.GetAll();
            Console.WriteLine("List of all elements: ");
            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            var salesInvoices = SalesInvoiceRepository.GetAll();
            Console.WriteLine("List of all salesInvoices: ");
            foreach (var salesInvoice in salesInvoices)
            {
                Console.WriteLine(salesInvoice);
            }
            Console.WriteLine();
        }
    }
}
