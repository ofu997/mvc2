﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
		// did anything change today? 09/05/17
		// processes requests for data, which template to use, redirects
        // GET: Home
        public ActionResult Index()
        {	
			// ctrl. makes "using HelloMVC.Models;"
			var cars = HelloModel.GetCars();

			ViewBag.OliverCreatedThisValue = "~hello MVC~";
			// generate a view that will be 
			// used by this actionresult method
			// this allows us to make a blank page 
            return View(cars );
        }
    }
}