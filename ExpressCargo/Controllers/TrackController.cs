using AutoMapper;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using ExpressCargo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExpressCargo.Controllers
{
	[AllowAnonymous]
	public class TrackController : Controller
	{
		OrderManager om = new OrderManager(new EfOrderDal());
		IMapper _mapper;
		public TrackController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index(string trackNumber)
		{
			var order = om.GetWithRelationsByTrackNumber(trackNumber);

			if (order == null)
			{
				TempData["TrackMessage"] = "Girdiğiniz takip numaralı kargo kaydı bulunamadı.";
				return RedirectToAction("Index", "Home");
			}

			TrackOrderVM vm = _mapper.Map<TrackOrderVM>(order);
			var cc = vm.Stages;
			return View(vm);
		}
	}
}
