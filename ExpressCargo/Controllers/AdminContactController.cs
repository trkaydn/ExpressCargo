using AutoMapper;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using ExpressCargo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpressCargo.Controllers
{
	public class AdminContactController : Controller
	{
		ContactManager cm = new ContactManager(new EfContactDal());
		IMapper _mapper;

		public AdminContactController(IMapper mapper)
		{
			_mapper = mapper;
		}
		
		public IActionResult Index()
		{
			//returns all contacts with mapping
			List<AdminContactVM> vm = new List<AdminContactVM>();

			foreach (var item in cm.GetOrderedList())
			{
				vm.Add(_mapper.Map<AdminContactVM>(item));
			}

			return View(vm);
		}

		public IActionResult Remove(int id)
		{
			//get contact by id and remove from db
			var value = cm.GetByID(id);
			cm.ContactDelete(value);

			return RedirectToAction("Index");
		}
	}
}
