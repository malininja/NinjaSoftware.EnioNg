using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.DatabaseGeneric.BusinessLogic;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace NinjaSoftware.EnioNg.Web.Controllers
{
    [Authorize(Roles = "User, Admin")]
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

        public ActionResult Config()
        {
            return View();
        }

        public FileContentResult RacunReport(long racunGlavaId)
        {
            string reportPath = Server.MapPath("~/ReportTemplates/Racun.xls");
            FlexCel.XlsAdapter.XlsFile xls = new FlexCel.XlsAdapter.XlsFile();
            xls.Open(reportPath);

            DataAccessAdapterBase adapter = Helpers.Helper.GetDataAccessAdapter();

            List<RacunReport> racunGlavaList = new List<RacunReport>();
            racunGlavaList.Add(new RacunReport(adapter, racunGlavaId));

            FlexCel.Report.FlexCelReport report = new FlexCel.Report.FlexCelReport();
            report.AddTable("Racun", racunGlavaList);
            report.Run(xls);

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                FlexCel.Render.FlexCelPdfExport pdfExport = new FlexCel.Render.FlexCelPdfExport(xls);
                pdfExport.BeginExport(ms);
                pdfExport.ExportAllVisibleSheets(false, "");
                pdfExport.EndExport();

                //xls.Save(ms);
                ms.Position = 0;

                return File(ms.ToArray(), "application/pdf");
            }
        }
    }
}
