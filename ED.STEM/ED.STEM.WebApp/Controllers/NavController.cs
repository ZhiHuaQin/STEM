using ED.STEM.Domain.Abstract;
using ED.STEM.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ED.STEM.WebApp.Controllers
{
    public class NavController : Controller
    {
        public ISTEMProgramsRepository ProgramsRepository { get; set; }
          = new EFSTEMProgramRepository();
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = ProgramsRepository
            .STEMPrograms
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x);

            return PartialView(categories);
        }
    }
}