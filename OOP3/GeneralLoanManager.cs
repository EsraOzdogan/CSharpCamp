using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class GeneralLoanManager : ICreditManager  //IhtiyacKrediManager
    { 
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Calculate()
        {
            Console.WriteLine("Consumer loan payment plan has been calculated");
        }
    }
}
