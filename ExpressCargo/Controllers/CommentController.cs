using AutoMapper;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using ExpressCargo.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpressCargo.Controllers
{
	[AllowAnonymous]
	public class CommentController : Controller
	{
		CommentManager cm = new CommentManager(new EfCommentDal());
		IMapper _mapper;

		public CommentController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			//get comment list and mapping
			List<CommentVM> vm = new List<CommentVM>();

			foreach (var item in cm.GetOrderedList())
			{
				vm.Add(_mapper.Map<CommentVM>(item));
			}

			return View(vm);
		}


		public PartialViewResult AddComment()
		{
			return PartialView();
		}

		[HttpPost]
		public PartialViewResult AddComment(CommentVM comment)
		{
			//get posted comment, mapping and save it to db
			var commentobject = _mapper.Map<Comment>(comment);

			CommentValidator validator = new CommentValidator();
			ValidationResult result = validator.Validate(commentobject);

			if (!result.IsValid)
			{
				foreach (var error in result.Errors)
				{
					ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
				}
				return PartialView(comment);
			}

			cm.CommentAdd(commentobject);
			TempData["CommentMessage"] = "Yorumuz başarıyla gönderildi. Onaylandıktan sonra yayınlanacaktır.";
			return PartialView();
		}

	}
}
