using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManager manager = new TestimonialManager(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = manager.TGetList();
            return View(values);
        }
    }
}
