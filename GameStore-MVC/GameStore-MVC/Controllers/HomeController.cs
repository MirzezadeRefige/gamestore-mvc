﻿using Microsoft.AspNetCore.Mvc;

namespace GameStore_MVC.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
