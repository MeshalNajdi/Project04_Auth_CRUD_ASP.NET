﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HjtProject.Controllers
{
    public class InstructorsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
