using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ICreditManager pFCManager = new PersonalFinanceCreditManager();
            
            ICreditManager tCManager = new TransportCreditManager();
            
            ICreditManager hCManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            List<ILoggerService> loggers = new List<ILoggerService> { new DatabaseLoggerService(), new FileLoggerService() };
            applicationManager.Apply(tCManager,loggers);
            
            List<ICreditManager> credits = new List<ICreditManager>() {};
            credits.Add(tCManager);
            credits.Add(hCManager);
            //applicationManager.MakeCreditPreInformation(credits);

        }
    }
}
