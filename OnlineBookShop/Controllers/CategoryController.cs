﻿using Microsoft.AspNetCore.Mvc;

namespace OnlineBookShop.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
