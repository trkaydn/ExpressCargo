using AutoMapper;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using ExpressCargo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpressCargo.Controllers
{
	[AllowAnonymous]
	public class HomeController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentDal());
		IMapper _mapper;
		public HomeController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			//select last 4 comment
			List<CommentVM> vm = new List<CommentVM>();

			foreach (var item in cm.GetLast4ActiveComments())
			{
				vm.Add(_mapper.Map<CommentVM>(item));
			}
			return View(vm);
		}

	}
}
