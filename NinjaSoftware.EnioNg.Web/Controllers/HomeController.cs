using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NinjaSoftware.EnioNg.CoolJ.DatabaseGeneric.BusinessLogic;
using SD.LLBLGen.Pro.ORMSupportClasses;
using NinjaSoftware.EnioNg.CoolJ.EntityClasses;
using NinjaSoftware.EnioNg.Web.Models;
using NinjaSoftware.EnioNg.CoolJ.HelperClasses;

namespace NinjaSoftware.EnioNg.Web.Controllers
{
    [Authorize(Roles = "User, Admin")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction(nameof(this.RacunList));
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
            DataAccessAdapterBase adapter = Helpers.Helper.GetDataAccessAdapter();
            long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);

            string reportPath = Server.MapPath(string.Format("~/ReportTemplates/{0}/Racun.xls", firmaId));
            FlexCel.XlsAdapter.XlsFile xls = new FlexCel.XlsAdapter.XlsFile();
            xls.Open(reportPath);

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

        public FileContentResult RacunReportCollection(string jqGridFilters)
        {
            DataAccessAdapterBase adapter = Helpers.Helper.GetDataAccessAdapter();
            long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);

            string reportPath = Server.MapPath(string.Format("~/ReportTemplates/{0}/Racun.xls", firmaId));
            FlexCel.XlsAdapter.XlsFile xls = new FlexCel.XlsAdapter.XlsFile();
            xls.Open(reportPath);

            short godina = ConfigEntity.GetInstance(adapter, firmaId).AktivnaGodina;
            RelationPredicateBucket bucket = RacunGlavaPager.CreateBucket(godina, jqGridFilters);
            bucket.PredicateExpression.Add(RacunGlavaFields.FirmaId == firmaId);

            IEnumerable<RacunReport> racunReportCollection = CoolJ.DatabaseGeneric.BusinessLogic.RacunReport.GetRacunReportCollection(adapter, bucket, firmaId);

            FlexCel.Report.FlexCelReport report = new FlexCel.Report.FlexCelReport();
            report.AddTable("Racun", racunReportCollection);
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

        public FileContentResult RacunReportCollectionAsList(string jqGridFilters)
        {
            DataAccessAdapterBase adapter = Helpers.Helper.GetDataAccessAdapter();
            long firmaId = UserEntity.GetFirmaId(adapter, User.Identity.Name);

            string reportPath = Server.MapPath(string.Format("~/ReportTemplates/{0}/RacunList.xls", firmaId));
            FlexCel.XlsAdapter.XlsFile xls = new FlexCel.XlsAdapter.XlsFile();
            xls.Open(reportPath);

            short godina = ConfigEntity.GetInstance(adapter, firmaId).AktivnaGodina;
            RelationPredicateBucket bucket = RacunGlavaPager.CreateBucket(godina, jqGridFilters);
            bucket.PredicateExpression.Add(RacunGlavaFields.FirmaId == firmaId);
            bucket.Relations.Add(RacunGlavaEntity.Relations.PartnerEntityUsingPartnerId);

            IEnumerable<RacunReport> racunReportCollection = NinjaSoftware.EnioNg.CoolJ.DatabaseGeneric.BusinessLogic.RacunReport.GetRacunReportCollection(adapter, bucket, firmaId);

            decimal ukupnoSum = racunReportCollection.Where(x => x.RacunGlava.JePdvRacun).Sum(x => x.Ukupno);
            ukupnoSum += racunReportCollection.Where(x => !x.RacunGlava.JePdvRacun).Sum(x => x.UkupnoBezPdv);

            FlexCel.Report.FlexCelReport report = new FlexCel.Report.FlexCelReport();
            report.AddTable("Racun", racunReportCollection);
            report.SetValue("UkupnoSum", ukupnoSum);
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
