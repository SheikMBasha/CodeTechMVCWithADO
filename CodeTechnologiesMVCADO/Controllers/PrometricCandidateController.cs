using CodeTechnologiesMVCADO.CodeTechWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeTechnologiesMVCADO.Controllers
{
    public class PrometricCandidateController : Controller
    {
        CodeTechnologiesServicesClient proxy = new CodeTechnologiesServicesClient();
        // GET: /PrometricCandidate/

        public ActionResult Index()
        {
            var pclist = proxy.GetAllPrometricCandidates();
            return View(pclist);
        }

        public ActionResult Create()
        {
            var examNatures = proxy.GetAllExamNature();
            IList<SelectListItem> enatureitems = new List<SelectListItem>();
            foreach (ExamNature nature in examNatures)
            {
                enatureitems.Add(new SelectListItem { Text = nature.Name, Value = nature.Id.ToString() });
            }
            ViewBag.examNatureDD = enatureitems;
            return View();
        }

    }
}
