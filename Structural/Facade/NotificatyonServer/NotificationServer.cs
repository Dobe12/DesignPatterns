using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.NotificatyonServer
{
    public class NotificationServer
    {
        public Connection Connect(string ip)
        {
            return new Connection();
        }

        public AuthToken Authenticate(string idUser, string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken token, Message message, string target)
        {
            Console.WriteLine("Sending a message");
        }

        public void Disconnect()
        {

        }
    }
}
