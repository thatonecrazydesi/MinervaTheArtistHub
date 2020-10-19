using Microsoft.AspNetCore.SignalR;
using UserAuth.Data;
using UserAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserAuth.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(Message message) =>
            await Clients.All.SendAsync("recieveMessage", message);
    }
}
