using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeTechnologiesMVCADO.CodeTechWCF;

namespace CodeTechnologiesMVCADO.Controllers
{
    public class AcademyController : Controller
    {
        CodeTechnologiesServicesClient proxy = new CodeTechnologiesServicesClient();
        public ActionResult Index()
        {

            var academyList = proxy.GetAllAcademies();
            return View(academyList);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AcademyModel academyObj)
        {
            proxy.AdddAcademy(academyObj);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var academyObj = proxy.getAcademy(id);
            return View(academyObj);
        }

        public ActionResult Edit(int id)
        {
            var academyObj = proxy.getAcademy(id);
            return View(academyObj);
        }

        [HttpPost]
        public ActionResult Edit(AcademyModel academyObj)
        {
            proxy.UpdateAcademy(academyObj);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            proxy.DeleteAcademy(id);
            return RedirectToAction("Index");
        }

    }
}
