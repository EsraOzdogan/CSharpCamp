using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService :ILoggerService //ILoggerService olamayabilirdi ama refeerans özelliğinden yararlanılmaz o zaman

    {
        public void Log()
        {
            Console.WriteLine("Logged to database");
        }
    }
}
