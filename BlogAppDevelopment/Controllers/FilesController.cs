using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IO = System.IO;
namespace BlogAppDevelopment.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        [ActionName("Pdf")]
        public ActionResult GetPdf(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
                return HttpNotFound("Given File Not exists. Please, Specify File name.");

            string fullPath = this.Server.MapPath($"~/Files/{name}.pdf");

            if (!IO.File.Exists(fullPath))
                return HttpNotFound("File Path doesn't exists.");

            return File(fullPath, contentType: "application/pdf",name+"pdf");
        }
        [ActionName("Photo")]
        public ActionResult GetPhoto(string name)
        {
            if (String.IsNullOrWhiteSpace(name))
                return HttpNotFound("Given File Not exists. Please, Specify File name.");

            string fullPath = this.Server.MapPath($"~/Files/Photos/{name}.png");

            if (!IO.File.Exists(fullPath))
                return HttpNotFound("File Path doesn't exists.");

            return File(fullPath, contentType: "image/png", name+"png");
        }
    }
}