using System;
using System.Text.RegularExpressions;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new NotificationService();
            service.Send("Hello guys", "PC-1");

            Console.ReadKey();
        }
    }
}
