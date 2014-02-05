using CodeTechnologiesMVCADO.CodeTechWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTechnologiesMVCADO.Controllers
{
    public class PromotionsController : Controller
    {
        CodeTechnologiesServicesClient proxy = new CodeTechnologiesServicesClient();

        public ActionResult Index()
        {
            var promotionsList = proxy.getAllPrometricPromotions();
            return View(promotionsList);
        }

        public ActionResult Indexwithid(int? siteid)
        {
            var promotionslist = proxy.getPrometricPromotionWithSiteId(siteid);
            ViewBag.siteId = siteid;
            ViewBag.PromotionExists = promotionslist.Count;
            return View(promotionslist);
        }

        public ActionResult create(int id)
        {
            ViewBag.passedsiteid = id;
            return View();
        }

        public ActionResult CustomerPrometricError()
        {
            return View();
        }

        [HttpPost]
        public ActionResult create(PrometricPromotions ppobj)
        {
            proxy.AddPrometricPromotion(ppobj);
            return RedirectToAction("Indexwithid", new { siteid = ppobj.SiteId });

        }

        public ActionResult details(int id)
        {
            var ppObj = proxy.getPrometricPromotion(id);
            return View(ppObj);
        }

        public ActionResult edit(int id)
        {
            var ppObj = proxy.getPrometricPromotion(id);
            return View(ppObj);
        }

        [HttpPost]
        public ActionResult edit(PrometricPromotions ppobj)
        {
            proxy.UpdatePrometricPromotion(ppobj);
            return RedirectToAction("Indexwithid", new { siteid = ppobj.SiteId });
        }

        public ActionResult delete(int id, int? siteid)
        {
            proxy.DeletePrometricPromotion(id);
            return RedirectToAction("Indexwithid", new { siteid = siteid });
        }

    }
}
