using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ExpressCargo.Controllers
{
	[AllowAnonymous]
	public class ErrorController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
