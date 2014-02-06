using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeTechnologiesMVCADO.CodeTechWCF;

namespace CodeTechnologiesMVCADO.Controllers
{
    public class ExpenseController : Controller
    {
        CodeTechnologiesServicesClient proxy = new CodeTechnologiesServicesClient();

        public ActionResult Index()
        {
            var expensesList = proxy.getAllExpenses();
            return View(expensesList);
        }

        public ActionResult Create()
        {
            var Prometrics = proxy.GetAllPrometrics();
            IList<SelectListItem> prometricItems = new List<SelectListItem>();
            prometricItems.Add(new SelectListItem { Text = "-- Please Select -- ", Value = "0".ToString() });
            foreach (Prometric p in Prometrics)
            {
                prometricItems.Add(new SelectListItem { Text = p.Name, Value = p.SiteId.ToString() });
            }
            ViewBag.SiteIds = prometricItems;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Expense expObj)
        {
            proxy.AddExpense(expObj);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var expObj = proxy.getExpense(id);
            return View(expObj);
        }

        public ActionResult Edit(int id)
        {
            var expObj = proxy.getExpense(id);
            var Prometrics = proxy.GetAllPrometrics();
            IList<SelectListItem> prometricItems = new List<SelectListItem>();
            prometricItems.Add(new SelectListItem { Text = "-- Please Select -- ", Value = "0".ToString() });
            foreach (Prometric p in Prometrics)
            {
                prometricItems.Add(new SelectListItem { Text = p.Name, Value = p.SiteId.ToString() });
            }
            ViewBag.SiteIds = prometricItems;
            return View(expObj);
        }

        [HttpPost]
        public ActionResult Edit(Expense expObj)
        {
            proxy.UpdateExpense(expObj);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            proxy.DeleteExpense(id);
            return RedirectToAction("Index");
        }
    }
}
