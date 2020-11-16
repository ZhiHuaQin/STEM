using ED.STEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ED.STEM.WebApp.Models
{
    public class STEMProgramsListViewModel
    {
        public IEnumerable<STEMProgram> STEMPrograms { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}