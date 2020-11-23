using ED.STEM.Domain.Abstract;
using ED.STEM.Domain.Concrete;
using ED.STEM.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ED.STEM.WebApp.Controllers
{
    public class STEMProgramController : Controller
    {
        public ISTEMProgramsRepository ProgramsRepository { get; set; }
             = new EFSTEMProgramRepository();

        public int PageSize = 3;

        public ViewResult List(string category, int page = 1)
        {
            STEMProgramsListViewModel model = new STEMProgramsListViewModel
            {
                STEMPrograms = ProgramsRepository
                    .STEMPrograms
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.STEMProgramId)
                    .Skip((page - 1) * PageSize)
                    .Take(PageSize),

                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null
                        ? ProgramsRepository.STEMPrograms.Count()
                        : ProgramsRepository.STEMPrograms.Where(e => e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
           
        }
    }
}