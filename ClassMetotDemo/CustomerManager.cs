using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.name + " adli kullanici eklendi ");

        }
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.name + " adli kullanici silindi");

        }

        public void List(params Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("kullanıcilar listeleniyor....");
                Console.WriteLine(customer.name + " adli kullanici listede ");
            }
        }
    }
}
