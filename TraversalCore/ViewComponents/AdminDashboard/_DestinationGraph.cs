using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.AdminDashboard
{
    public class _DestinationGraph : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {  
            return View(); 
        }
    }
}
