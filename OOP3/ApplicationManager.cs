using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Başvuru
    class ApplicationManager
    {
        //BaşvuruYap
        public void MakeAnApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        //KrediÖnBilgilendirmesiYap
        public void MakeCreditPreNotification(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
