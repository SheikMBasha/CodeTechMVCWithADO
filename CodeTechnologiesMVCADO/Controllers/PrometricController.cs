using CodeTechnologiesMVCADO.CodeTechWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTechnologiesMVCADO.Controllers
{
    public class PrometricController : Controller
    {
        CodeTechnologiesServicesClient proxy = new CodeTechnologiesServicesClient();
        // GET: /Prometric/

        public ActionResult Index()
        {
            var plist = proxy.GetAllPrometrics();
            return View(plist);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Prometric pObj)
        {
            proxy.AddPrometric(pObj);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var pObj = proxy.getPrometric(id);
            return View(pObj);
        }

        public ActionResult Edit(int id)
        {
            var pObj = proxy.getPrometric(id);
            return View(pObj);
        }

        [HttpPost]
        public ActionResult Edit(Prometric pObj)
        {
            proxy.UpdatePrometric(pObj);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            proxy.DeletePrometric(id);
            return RedirectToAction("Index");
        }

    }
}
