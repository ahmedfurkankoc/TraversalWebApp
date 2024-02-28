using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTO;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactUsManager contactUsManager = new ContactUsManager(new EfContactUsDal());
        private readonly IContacUsService _contacUsService;
        private readonly IMapper _mapper;

        public ContactController(IContacUsService contacUsService, IMapper mapper)
        {
            _contacUsService = contacUsService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDTO model)
        {
            if (ModelState.IsValid)
            {
                _contacUsService.TAdd(new ContactUs()
                {
                    Message = model.Message,
                    Email = model.Email,
                    MessageStatus = model.MessageStatus,
                    Name = model.Name,
                    Subject = model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                });
                return RedirectToAction("Index", "Default");
            }

            return View(model);
        }
    }
}
