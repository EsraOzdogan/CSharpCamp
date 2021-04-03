using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager //BasvuruManager
    {
        public void MakeApplication(ICreditManager creditManager, ILoggerService loggerService)//başvuru yap
        {
            //başvuran bilgilerini değerlendirme
            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();//Tüm başvurular konut kredisi için yapılmış oldu.Fonksiyona parametre alıp tüm krediler için ortak gerçekleşiyor
            //mortgageLoanManager.Calculate();
            creditManager.Calculate();
            loggerService.Log(); //hangi loggerservice verilmişse onları logla
        }
        public void MakeCreditPrenotification(List<ICreditManager> loans) //listedeki her kredinin hesabını yap
        {
            foreach (var credit in loans)
            {
                credit.Calculate();
            }
        }
    }
}
