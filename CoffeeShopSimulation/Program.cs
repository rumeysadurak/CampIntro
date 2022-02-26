using System;
using CoffeeShopSimulation.Abstract;
using CoffeeShopSimulation.Concrete;
using CoffeeShopSimulation.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopSimulation.Adapters;

namespace CoffeeShopSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //no mernis verification required
            BaseCustomerManager customerManager1 = new NeroCustomerManager();
            customerManager1.Save(new Customer { DateOfBirth = new DateTime(1999,1,7),FirstName="Rümeysa",LastName="Durak",NationalityId="11111111111", });
            
            //Since mernis verification is requested, correct information must be entered
            BaseCustomerManager customerManager2 = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager2.Save(new Customer { DateOfBirth = new DateTime(1999, 1, 7), FirstName = "Rümeysa", LastName = "Durak", NationalityId = "20253619468", });
            Console.ReadLine();
        
        }
    }
}
