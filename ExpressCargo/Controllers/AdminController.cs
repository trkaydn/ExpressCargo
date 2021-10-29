using AutoMapper;
using BusinessLayer.Concrete;
using BusinessLayer.PasswordHasher;
using DataAccessLayer.EntityFramework;
using ExpressCargo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;

namespace ExpressCargo.Controllers
{
	public class AdminController : Controller
	{
		ContactManager ctm = new ContactManager(new EfContactDal());
		CommentManager cm = new CommentManager(new EfCommentDal());
		OrderManager om = new OrderManager(new EfOrderDal());
		DistrictManager dm = new DistrictManager(new EfDistrictDal());
		IMapper _mapper; 
		AdminVM vm = new AdminVM();

		public AdminController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			//get active admin and get admin's orders
			var userName = User.FindFirstValue(ClaimTypes.Name);
			var activeDistrictId = dm.GetByLoginName(userName).DistrictID;
			var orders = om.GetOrderedListByDistrictID(activeDistrictId);

			vm.Waiting = orders.Where(x => x.StatusID == 1).Count();
			vm.OnRoad = orders.Where(x => x.StatusID == 2).Count();
			vm.OnArrival = orders.Where(x => x.StatusID == 3 || x.StatusID == 4).Count();
			vm.Completed = orders.Where(x => x.StatusID == 5).Count();
			vm.All = orders.Count();

			//all admins can CRUD comments and contacts. Add last 3 comment and contact to index page for preview
			foreach (var item in cm.GetOrderedList().Take(3))
			{
				vm.LastComments.Add(_mapper.Map<AdminCommentVM>(item));
			}

			foreach (var item in ctm.GetOrderedList().Take(3))
			{
				vm.LastContacts.Add(_mapper.Map<AdminContactVM>(item));
			}
			return View(vm);
		}

		public ActionResult ChangePassword()
		{
			return View();
		}

		[HttpPost]
		public ActionResult ChangePassword(ChangePasswordVM p)
		{
			//password minlength 5
			if (string.IsNullOrEmpty(p.NewPassword) || string.IsNullOrEmpty(p.OldPassword) || p.NewPassword.Length < 5)
			{
				ViewBag.PasswordMesage = "Şifreniz en az 5 karakterden oluşmalıdır.";
				return View();
			}

			//get active admin
			var userName = User.FindFirstValue(ClaimTypes.Name);
			var activeUser = dm.GetByLoginName(userName);

			if (activeUser.Password != SHA512Hasher.Hash(p.OldPassword))
			{
				ViewBag.PasswordMesage = "Mevcut şifre hatalı girildi.";
				return View();
			}

			if (p.NewPassword != p.NewPasswordControl)
			{
				ViewBag.PasswordMesage = "Girilen şifreler uyuşmuyor.";
				return View();
			}

			activeUser.Password = SHA512Hasher.Hash(p.NewPassword);
			dm.DistrictUpdate(activeUser);
			ViewBag.PasswordMesageOK = "Şifeniz başarıyla güncellendi.";
			return View();
		}
	}
}
