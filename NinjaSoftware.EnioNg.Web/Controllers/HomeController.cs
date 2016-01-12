using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.EnioNg.CoolJ.DatabaseSpecific;

namespace NinjaSoftware.EnioNg.Web.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Tarifa()
        {
            return View();
        }

        public ActionResult RacunList()
        {
            return View();
        }

        public ActionResult RacunEdit()
        {
            return View();
        }

        public FileContentResult RacunReport(long racunGlavaId)
        {
            string reportPath = Server.MapPath("~/ReportTemplates/Racun.xls");
            FlexCel.XlsAdapter.XlsFile xls = new FlexCel.XlsAdapter.XlsFile();
            xls.Open(reportPath);

            DataAccessAdapter adapter = new DataAccessAdapter();
            RacunGlavaEntity racunGlava = RacunGlavaEntity.FetchRacunGlavaForReport(adapter, racunGlavaId);
            List<RacunGlavaEntity> racunGlavaList = new List<RacunGlavaEntity>();
            racunGlavaList.Add(racunGlava);

            FlexCel.Report.FlexCelReport report = new FlexCel.Report.FlexCelReport();
            report.AddTable("Racun", racunGlavaList);
            report.Run(xls);

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                xls.Save(ms);
                ms.Position = 0;

                return File(ms.ToArray(), "application/pdf");
            }
        }
    }
}
