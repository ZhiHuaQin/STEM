using ED.STEM.Domain.Abstract;
using ED.STEM.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED.STEM.Domain.Concrete
{
   public class EFSTEMProgramRepository: ISTEMProgramsRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable <STEMProgram> STEMPrograms
        {
            get { return context.STEMPrograms; }
        }
    }
}
