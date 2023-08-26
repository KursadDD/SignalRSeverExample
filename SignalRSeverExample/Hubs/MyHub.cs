using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRSeverExample.Hubs
{
    public class MyHub : Hub 
    {
        public async Task SendMessageAsync (string message)
         {
            await Clients.All.SendAsync("receiveMessage", message);
            //client tarafından gönderilen "message" ı ala tüm clientlardaki "receiveMessage" 
            //isimli metodu tetikle ve "message" ı tüm clientlara yolla
        }
    }
}
