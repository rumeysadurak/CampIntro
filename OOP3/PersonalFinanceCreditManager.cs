using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class PersonalFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            
            Console.WriteLine("Personal Finance Loan payment plan calculated");
        }

        public void Print()
        {
            throw new NotImplementedException();
        }
    }
}
