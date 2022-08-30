using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.name = "christian ozera";
            customer1.job = "engineer";
            customer1.id = 1234;

            Customer customer2 = new Customer();
            customer2.name = "Mad max";
            customer2.id = 1436;
            customer2.job = "driver";

            Customer customer3 = new Customer();
            customer3.name = "carl johanson";
            customer3.id = 35447;
            customer3.job = "police";

            CustomerManager operation=new CustomerManager();
            operation.Add(customer1);
            operation.Delete(customer2);
            operation.List(customer1, customer2,customer3);

        }
    }
}