using Microsoft.AspNetCore.SignalR;
using SignalRAPI.Model;

namespace SignalRAPI.Hub
{
    public class VisitorHub : IHubContext
    {
        private readonly IHubContext<VisitorHub> _hubContext;
        private readonly VisitorService _visitorService;

        public VisitorHub(IHubContext<VisitorHub> hubContext, VisitorService visitorService)
        {
            _hubContext = hubContext;
            _visitorService = visitorService;
        }
    }

    public async Task GetVisitorList()
        {
            var visitors = await _visitorService.GetVisitorList();
            await _hubContext.Clients.All.SendAsync("CallVisitList", visitors);
        }
    }
}
