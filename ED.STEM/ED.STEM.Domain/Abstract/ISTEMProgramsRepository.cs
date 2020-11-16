using ED.STEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED.STEM.Domain.Abstract
{
   public interface ISTEMProgramsRepository
    {
        IEnumerable<STEMProgram> STEMPrograms { get; }
    }
}
