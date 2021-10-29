using AutoMapper;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using ExpressCargo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpressCargo.Controllers
{
	public class AdminCommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentDal());
		IMapper _mapper;

		public AdminCommentController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index()
		{	
			//returns all comments with mapping
			List<AdminCommentVM> vm = new List<AdminCommentVM>();

			foreach (var item in cm.GetOrderedList())
			{
				vm.Add(_mapper.Map<AdminCommentVM>(item));
			}

			return View(vm);
		}

		public IActionResult Remove(int id)
		{
			//get comment by id and remove from db
			var value = cm.GetByID(id);
			cm.CommentDelete(value);

			return RedirectToAction("Index");
		}

		public IActionResult ChangeStatus(int id)
		{
			//get comment by id and set isactive= true
			var value = cm.GetByID(id);
			switch (value.IsActive)
			{
				case false:
					value.IsActive = true;
					break;
			}
			cm.CommentUpdate(value);

			return RedirectToAction("Index");
		}
	}
}
