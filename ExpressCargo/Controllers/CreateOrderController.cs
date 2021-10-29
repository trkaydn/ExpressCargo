using AutoMapper;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using ExpressCargo.Models;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ExpressCargo.Controllers
{
	public class CreateOrderController : Controller
	{
		OrderManager om = new OrderManager(new EfOrderDal());
		DistrictManager dm = new DistrictManager(new EfDistrictDal());
		StageManager sm = new StageManager(new EfStageDal());
		CityManager cm = new CityManager(new EfCityDal());
		SizeManager szm = new SizeManager(new EfSizeDal());
		IMapper _mapper;

		CreateOrderVM vm = new CreateOrderVM();

		public CreateOrderController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			FillVm();
			return View(vm);
		}

		[HttpPost]
		public IActionResult Index(CreateOrderVM p)
		{
			//validate new order and add to db.
			var orderValue = _mapper.Map<Order>(p);

			OrderValidator validator = new OrderValidator();
			ValidationResult result = validator.Validate(orderValue);

			if (!result.IsValid)
			{
				foreach (var error in result.Errors)
					ModelState.AddModelError(error.PropertyName, error.ErrorMessage);

				FillVm();
				return View(vm);
			}

			var userName = User.FindFirstValue(ClaimTypes.Name);
			var senderDistrictId = dm.GetByLoginName(userName).DistrictID;

			orderValue.TrackNumber = GetRandomNumber();
			orderValue.SenderDistrictID = senderDistrictId;
			orderValue.StatusID = 1;

			om.OrderAdd(orderValue);

			//add first stage of new order to db
			sm.StageAdd(new Stage()
			{
				OrderID = orderValue.OrderID,
				StatusID = 1,
			});

			TempData["TrackNumber"] = orderValue.TrackNumber;
			return RedirectToAction("Success");
		}

		public JsonResult GetDistricts(int cityId)
		{
			//get selected city's districs with ajax
			List<SelectListItem> result = new List<SelectListItem>();

			result = (from x in dm.GetByCityID(cityId)
					  select new SelectListItem
					  {
						  Text = x.DistrictName,
						  Value = x.DistrictID.ToString()
					  }).ToList();

			return Json(result);
		}

		public IActionResult Success()
		{
			return View();
		}

		public void FillVm()
		{
			//fill seleclists in vm
			vm.Cities = (from x in cm.GetList()
						 select new SelectListItem
						 {
							 Text = x.CityName,
							 Value = x.CityID.ToString()
						 }).ToList();


			vm.Sizes = (from x in szm.GetList()
						select new SelectListItem
						{
							Text = x.SizeName,
							Value = x.SizeID.ToString()
						}).ToList();
		}

		public string GetRandomNumber()
		{
			//create a random 12 digit number for track order
			var random = new Random();
			var result = string.Empty;
			for (int i = 0; i < 12; i++)
			{
				result += random.Next(0, 10);
			}

			return result;
		}
	}
}
