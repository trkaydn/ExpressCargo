using AutoMapper;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using ExpressCargo.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExpressCargo.Controllers
{
	[AllowAnonymous]
	public class ContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactDal());
		IMapper _mapper;

		public ContactController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult AddContact()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult AddContact(ContactVM contact)
		{
			//get posted contact, mapping and save it to db
			var contactValue = _mapper.Map<Contact>(contact);

			ContactValidator validator = new ContactValidator();
			ValidationResult result = validator.Validate(contactValue);

			if (!result.IsValid)
			{
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
				}
				return PartialView(contact);
			}

			cm.ContactAdd(contactValue);
			TempData["ContactMessage"] = "Mesajınız başarıyla iletildi.";
			return PartialView();
		}

	}
}
