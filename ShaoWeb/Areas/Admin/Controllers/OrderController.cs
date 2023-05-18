using Microsoft.AspNetCore.Mvc;

namespace ShaoWeb.Areas.Admin.Controllers
{
	public class OrderController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
