﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NinjaSoftware.EnioNg.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Partner()
		{
			return View();
		}
		
		public ActionResult Artikl()
		{
			return View();
		}

        public ActionResult Pdv()
        {
            return View();
        }
    }
}
