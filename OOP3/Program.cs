using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            PersonelFinanceCreditManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
            personelFinanceCreditManager.Calculate();

            TransportCreditManager transportCreditManager = new TransportCreditManager();
            transportCreditManager.Calculate();

            MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            mortgageCreditManager.Calculate();
            */

            //Görüldüğü üzere 3 yerde ICreditManager'ı implemente ettiği için ICreditManager'dan hepsini türetebilirim.
            ICreditManager personelFinanceCreditManager = new PersonelFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();

            //aşağıdaki şekilde de yazabilirim alternatifi(Not:List yaptım ondan hata verir)
            //applicationManager.MakeAnApplication(mortgageCreditManager, databaseLoggerService); 
            //<applicationManager.MakeAnApplication(mortgageCreditManager, new DatabaseLoggerService());

            //List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService, fileLoggerService };
            //applicationManager.MakeAnApplication(transportCreditManager, loggerServices);

            //Hemen üstündeki 2 satırın alternatifidir. Tek satır yazılmak istenince
            applicationManager.MakeAnApplication(transportCreditManager, new List<ILoggerService>() { databaseLoggerService, fileLoggerService, smsLoggerService });


            List<ICreditManager> credits = new List<ICreditManager>() { personelFinanceCreditManager, transportCreditManager };
            //applicationManager.MakeCreditPreNotification(credits);
        }
    }
}
