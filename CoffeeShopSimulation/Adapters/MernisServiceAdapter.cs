﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopSimulation.Abstract;
using CoffeeShopSimulation.Entities;
using CoffeeShopSimulation.MernisServiceReference;

namespace CoffeeShopSimulation.Adapters
{
    class MernisServiceAdapter : ICustomerCheckService
    {
        //mernis verification
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(Convert.ToInt64(customer.NationalityId),customer.FirstName.ToUpper(),customer.LastName.ToUpper(),customer.DateOfBirth.Year);
          
        }
    }
}
