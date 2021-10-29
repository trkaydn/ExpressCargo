using AutoMapper;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using ExpressCargo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ExpressCargo.Controllers
{
	public class AdminOrderController : Controller
	{
		DistrictManager dm = new DistrictManager(new EfDistrictDal());
		OrderManager om = new OrderManager(new EfOrderDal());
		StatusManager sm = new StatusManager(new EfStatusDal());
		StageManager sgm = new StageManager(new EfStageDal());
		IMapper _mapper;

		public AdminOrderController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index(int? id)
		{
			//find district's orders and return list
			var userName = User.FindFirstValue(ClaimTypes.Name);
			var districtId = dm.GetByLoginName(userName).DistrictID;
			List<AdminOrderVM> vm = new List<AdminOrderVM>();

			foreach (var item in om.GetListWithRelations(districtId))
			{
				vm.Add(_mapper.Map<AdminOrderVM>(item));
			}

			if (id != null)
			{
				if (id == 3)
					vm = vm.Where(x => x.StatusID == 3 || x.StatusID == 4).ToList();
				else
					vm = vm.Where(x => x.StatusID == id).ToList();

				switch (id)
				{
					case 1:
						ViewBag.Header = "Sevk Bekleyen Kargolar";
						break;
					case 2:
						ViewBag.Header = "Yola Çıkmış Kargolar";
						break;
					case 3:
						ViewBag.Header = "Varış Şubesinde - Teslimatta Olan Kargolar";
						break;
					case 5:
						ViewBag.Header = "Teslim Edilmiş Kargolar";
						break;
				}

			}

			else
				ViewBag.Header = "Tüm Kargolar";

			return View(vm);
		}

		public IActionResult Edit(int id)
		{
			//find order and create Status selectlist (selectlist not include past stages)
			AdminUpdateOrderVM vm = new AdminUpdateOrderVM();
			var order = om.GetWithStages(id);
			vm = _mapper.Map<AdminUpdateOrderVM>(order);

			vm.StatusList = (from x in sm.GetListGreaterThanDistrictStatus(vm.StatusID)
							 select new SelectListItem
							 {
								 Text = x.StatusName,
								 Value = x.StatusID.ToString()
							 }).ToList();

			return View(vm);
		}

		[HttpPost]
		public IActionResult Edit(AdminUpdateOrderVM p)
		{
			//find order and update order's status and add new stage
			var order = om.GetWithStages(p.OrderID);
			if (order.StatusID != p.StatusID)
			{
				order.StatusID = p.StatusID;

				sgm.StageAdd(new Stage()
				{
					OrderID = order.OrderID,
					StatusID = order.StatusID,
					StatusDate = DateTime.Now

				});

				om.OrderUpdate(order);
			}

			TempData["OrderMessage"] = "Kargo durumu başarıyla güncellendi.";
			return RedirectToAction("Index");
		}
	}
}
