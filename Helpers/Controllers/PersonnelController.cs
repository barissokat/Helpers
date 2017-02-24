using Helpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Helpers.Controllers
{
    public class PersonnelController : Controller
    {

        public ActionResult Create()
        {
            return View(new Personnel());
        }

        [HttpPost]
        public ActionResult Create(Personnel newPersonnel)
        {
            bool validation = ModelState.IsValid;
            return View(newPersonnel);
        }
    }
}