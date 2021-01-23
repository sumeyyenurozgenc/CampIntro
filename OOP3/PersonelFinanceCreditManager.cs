using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //ihtiyaç Kredisi
    class PersonelFinanceCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
