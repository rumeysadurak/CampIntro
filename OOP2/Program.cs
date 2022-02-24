using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "121364";
            customer1.Name = "Rumeysa";
            customer1.Surname = "Durak";
            customer1.IdNumber = "12345678977";

            CorporateCustomer customer2 = new CorporateCustomer();

            customer2.CustomerNumber = "1234678";
            customer2.CompanyName = "Kodlama";
            customer2.Id = 2;
            customer2.TaxNumber = "458684859464";


            //SOLID

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager manager = new CustomerManager();
            manager.Add(customer4);
            manager.Add(customer3);


        }
    }
}
