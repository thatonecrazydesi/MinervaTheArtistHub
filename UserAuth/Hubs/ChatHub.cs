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
        public async Task SendMessage(ChatRoom message) =>
            await Clients.All.SendAsync("RecieveMessage", message);// Message will be sent to all users within the system...

        public async Task SendMessageToCaller(ChatRoom message) =>
            await Clients.Caller.SendAsync("RecieveMessage", message); // allows you to send reply back to sender.


    }
}
