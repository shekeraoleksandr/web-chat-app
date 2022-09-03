﻿using Microsoft.AspNetCore.SignalR;                                      
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Public_Chat.Hubs
{
    public class ChatHub: Hub
    {
        public Task SendMessage1(string user, string message)
        {
            return Clients.All.SendAsync("RecieveOne", user, message);
        }
    }
}
