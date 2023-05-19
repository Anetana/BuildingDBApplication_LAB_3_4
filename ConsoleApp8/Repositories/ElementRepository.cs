using ConsoleApp8.Data;
using ConsoleApp8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.Repositories
{
    public class ElementRepository
    {
        public static void Save(Element element)
        {
            using (MyDBContext context = new MyDBContext())
            {
                if (element.Id != 0)
                {
                    context.Elements.Update(element);
                }
                else
                {
                    context.Elements.Add(element);
                }

                context.SaveChanges();
            }


        }

        public static List<Element> GetAll()
        {
            using (MyDBContext context = new MyDBContext())
            {
                var elements = context.Elements.ToList();
                return elements;
            }

        }
    }
}
