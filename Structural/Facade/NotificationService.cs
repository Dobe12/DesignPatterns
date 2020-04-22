using System;
using System.Collections.Generic;
using System.Text;
using Facade.NotificatyonServer;

namespace Facade
{
    public class NotificationService
    {
        public void Send(string message, string rarget)
        {
            var server = new NotificationServer();
            var connection = server.Connect("192.168.1.1");
            var authToken = server.Authenticate("23", "322");
            server.Send(authToken, new Message(message), rarget);
            server.Disconnect();
        }
    }
}
