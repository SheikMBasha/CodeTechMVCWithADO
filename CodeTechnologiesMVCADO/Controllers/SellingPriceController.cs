using CodeTechnologiesMVCADO.CodeTechWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTechnologiesMVCADO.Controllers
{
    public class SellingPriceController : Controller
    {
        CodeTechnologiesServicesClient proxy = new CodeTechnologiesServicesClient();

        public ActionResult Index()
        {
            var pricelist = proxy.GetAllSellingPrices();
            return View(pricelist);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(SellingPricing price)
        {
            proxy.AddNewPricing(price);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var priceObj = proxy.GetPricing(id);
            return View(priceObj);
        }

        public ActionResult Edit(int id)
        {
            var priceObj = proxy.GetPricing(id);
            return View(priceObj);
        }

        [HttpPost]
        public ActionResult Edit(SellingPricing price)
        {
            proxy.UpdatePricing(price);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            proxy.DeletePricing(id);
            return RedirectToAction("Index");
        }

    }
}
