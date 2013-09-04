using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.DatabaseSpecific;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;

namespace NinjaSoftware.EnioNg.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
			DataAccessAdapter adapter = new DataAccessAdapter();
			IEnumerable<EntityRoEntity> partnerCollection = EntityRoEntity.FetchEntityRoCollection (adapter, null, null);

            return View();
        }

    }
}
