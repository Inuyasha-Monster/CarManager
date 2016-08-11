using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace CarManager.Web.SignarlR.MyHubs
{
    public class MessageHub : Hub
    {
        public void SendMessage(string message)
        {
            Clients.All.SendMessage(message);
        }
    }
}