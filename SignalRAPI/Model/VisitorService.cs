using Microsoft.AspNetCore.SignalR;
using SignalRAPI.DAL;

namespace SignalRAPI.Model
{
    public class VisitorService
    {
        private readonly Context _context;
        private readonly IHubContext<Visitor> _hubContext;
    }
}
