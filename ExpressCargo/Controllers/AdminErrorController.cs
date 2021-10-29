using AutoMapper;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using ExpressCargo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpressCargo.Controllers
{
	public class AdminErrorController : Controller
	{
		ExceptionLogManager em = new ExceptionLogManager(new EfExceptionLogDal());
		IMapper _mapper;

		public AdminErrorController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			//get errors then mapping and return
			List<AdminErrorVM> vm = new List<AdminErrorVM>();

			foreach (var item in em.GetList())
				vm.Add(_mapper.Map<AdminErrorVM>(item));

			return View(vm);
		}

		public IActionResult Delete(int errorId)
		{
			var error = em.GetByID(errorId);
			em.ExceptionLogDelete(error);
			return RedirectToAction("Index");
		}
	}
}
