﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnePieceWebsite.Controllers
{
    public class DevilFruitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}