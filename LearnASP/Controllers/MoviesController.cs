﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LearnASP.Models;

namespace LearnASP.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Moives
        public ActionResult Random()
        {
            Movie movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }
    }
}