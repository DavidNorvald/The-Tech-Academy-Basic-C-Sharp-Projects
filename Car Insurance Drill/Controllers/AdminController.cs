using Car_Insurance_Drill.Models;
using Car_Insurance_Drill.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Car_Insurance_Drill.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceEntities db = new InsuranceEntities())      // creates connection to the Db
            {
                var insurancequotes = db.AutoInsuranceQuotes.Where(x => x.Removed == null).ToList();
                var insuranceQuotesVms = new List<InsuranceVM>();
                foreach (var quote in insurancequotes)
                {
                    var insuranceVm = new InsuranceVM();
                    insuranceVm.Id = quote.Id;
                    insuranceVm.FirstName = quote.FirstName;
                    insuranceVm.LastName = quote.LastName;
                    insuranceVm.EmailAddress = quote.EmailAddress;
                    insuranceVm.Total = Convert.ToInt32(quote.Total);
                    insuranceQuotesVms.Add(insuranceVm);
                }
                return View(insuranceQuotesVms);
            }
        }
        public ActionResult CancelPolicy(int Id)
        {
            using (InsuranceEntities db = new InsuranceEntities())        // creates connection to the Db
            {
                var quote = db.AutoInsuranceQuotes.Find(Id);       // quote is able to find a specific record by Id in the Db
                quote.Removed = DateTime.Now;          // changes the Removed column to DateTime.Now so column is no longer Null
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}