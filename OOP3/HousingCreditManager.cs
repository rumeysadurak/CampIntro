using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing Loan payment plan calculated");
           
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
