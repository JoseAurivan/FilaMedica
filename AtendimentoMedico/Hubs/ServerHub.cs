using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace AtendimentoMedico.Hubs
{
    public class ServerHub : Hub
    {
        public Task SendMessage()
        {
            return Clients.All.SendAsync("ReceiveMessage");
        }

        public Task SendPrority()
        {
            return Clients.All.SendAsync("ReceivePriority");
        }
    }
}