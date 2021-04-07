using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //GeneralLoanManager generalLoanManager = new GeneralLoanManager(); alttaki ile aynı.İnterfacelerde o interfacei implemente eden classın referans numarasını tutabiliyomuş.
            //ICreditManager generalLoanManager = new GeneralLoanManager();
            //generalLoanManager.Calculate();

            //VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
            //ICreditManager vehicleLoanManager = new VehicleLoanManager();
            //vehicleLoanManager.Calculate();

            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            //ICreditManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();


            //Kullanıcı ekranında bu krediler seçenek
            ICreditManager generalLoanManager = new GeneralLoanManager();
            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            //ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.MakeApplication(generalLoanManager);   //yani ekranda ihtiyaç kredisi seçildiğinde o kredinin hesapla fon ekrana yazılır.

            //List<ICreditManager> loans = new List<ICreditManager>() { }; //kullanıcı kendi durumuna göre krediler asında filtrelem yapıldı ekranda seçilen krediler listelenerek ödeme hesabı yapıldı
            //applicationManager.MakeCreditPrenotification(loans);

            //Loglama kim ne zaman hangi operasyonu çağırdı, sistemde olan hareketlerin dokümanı.Loglama, dosya, veritabanı olarak tuutulabilir veya sms olarak tutulabilir.


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SmsLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(new VehicleLoanManager(), smsLoggerService); //tasit kredisi yolllanna kişiye smsde yolla.  VehicleLoanManager için yeni instance burda da bu şekilde oluşturulabilir.




            //Birden fazla logger yollama
            //List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            //ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.MakeApplication(new MortgageLoanManager(), loggers);

            //List<ICreditManager> loans = new List<ICreditManager>() { VehicleLoanManager, GeneralLoanManager };

            //applicationManager.MakeCreditPrenotification(loans);        

        }
    }
}