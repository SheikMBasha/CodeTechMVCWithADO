using CodeTechnologiesMVCADO.CodeTechWCF;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;

namespace CodeTechnologiesMVCADO.Controllers
{
    public class PearsonCandidateController : Controller
    {
        CodeTechnologiesServicesClient proxy = new CodeTechnologiesServicesClient();
        // GET: /PrometricCandidate/

        public ActionResult Index()
        {
            var pclist = proxy.GetAllPearsonCandidates();
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

        [HttpPost]
        public ActionResult Create(PearsonCandidate pcObj)
        {
            proxy.AddPearsonCandidate(pcObj);
            return RedirectToAction("Index");
        }

        public ActionResult BulkUpload()
        {
            return View();
        }

        [HttpPost]
        public ActionResult BulkUpload(HttpPostedFileBase file)
        {
            if (Request.Files["FileUpload"].ContentLength > 0)
            {
                int filePosition = 0;
                int filePart = 16 * 1024;
                byte[] bufferData = new byte[filePart];
                Stream fileStream = Request.Files["FileUpload"].InputStream;
                try
                {
                    long actualFileSize = Request.Files["FileUpload"].ContentLength;
                    fileStream.Position = filePosition;
                    int fileBytesRead = 0;
                    while (filePosition != actualFileSize)
                    {
                        fileBytesRead = fileStream.Read(bufferData, 0, filePart);
                        if (fileBytesRead != bufferData.Length)
                        {
                            filePart = fileBytesRead;
                            byte[] bufferedDataToWrite = new byte[fileBytesRead];
                            Array.Copy(bufferData, bufferedDataToWrite, fileBytesRead);
                            bufferData = bufferedDataToWrite;
                        }

                        proxy.BulkUploadPearsonCandidates(new FileData
                        {
                            FileName = Request.Files["FileUpload"].FileName,
                            BufferData = bufferData,
                            FilePosition = filePosition
                        });
                        filePosition += fileBytesRead;


                    }

                }
                catch (FaultException fex)
                {
                    return null;
                }
                finally
                {
                    fileStream.Close();
                }
                
            }
            return RedirectToAction("Index");

        }

        public ActionResult Edit(int id)
        {
            var pcObj = proxy.getPearsonCandidate(id);
            return View(pcObj);
        }

        [HttpPost]
        public ActionResult Edit(PearsonCandidate pcObj)
        {
            proxy.UpdatePearsonCandidate(pcObj);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var pcObj = proxy.getPearsonCandidate(id);
            return View(pcObj);
        }

        public ActionResult Delete(int id)
        {
            proxy.DeletePearsonCandidate(id);
            return RedirectToAction("Index");
        }

    }
}
