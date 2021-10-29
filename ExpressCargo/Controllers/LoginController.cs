using AutoMapper;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using ExpressCargo.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ExpressCargo.Controllers
{
	[AllowAnonymous]
	public class LoginController : Controller
	{
		//each district is a user(admin), they can login and send order to another district,change password,edit comments,edit contacts etc.
		DistrictManager dm = new DistrictManager(new EfDistrictDal());
		IMapper _mapper;

		public LoginController(IMapper mapper)
		{
			_mapper = mapper;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Index(LoginVM p)
		{
			if (string.IsNullOrEmpty(p.LoginName) || string.IsNullOrEmpty(p.Password))
			{
				ViewBag.LoginMessage = "Şube adı veya şifre yanlış girildi.";
				return View();
			}

			var values = dm.GetByLoginNamePassword(p.LoginName, p.Password);

			if (values == null)
			{
				ViewBag.LoginMessage = "Şube adı veya şifre yanlış girildi.";
				return View();
			}

			var claims = new List<Claim>()
				{
					new Claim(ClaimTypes.Name, values.LoginName)
				};

			var useridentity = new ClaimsIdentity(claims, "a");
			ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
			await HttpContext.SignInAsync(principal);
			return RedirectToAction("Index", "Admin");
		}

		[Authorize]
		public async Task<IActionResult> Logout()
		{
			//this variable get authenticated user's loginname
			//var userName = User.FindFirstValue(ClaimTypes.Name);

			await HttpContext.SignOutAsync();
			return RedirectToAction("Index", "Home");
		}

	}
}
